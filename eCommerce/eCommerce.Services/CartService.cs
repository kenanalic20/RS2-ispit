using System.Xml.Schema;
using Azure.Core;
using eCommerce.Model;
using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
    public class CartService:BaseCRUDService<CartResponse,BaseSearchObject,Cart,CartRequest,CartRequest>
    {
        protected readonly eCommerceDbContext _context;
        protected readonly CartEventIB200116Service _cartEventService;
        public CartService(eCommerceDbContext context,CartEventIB200116Service cartEventService,IMapper mapper):base(context,mapper)
        {
            _context=context;
            _cartEventService = cartEventService;
        }
        protected override IQueryable<Cart> ApplyFilter(IQueryable<Cart> query, BaseSearchObject search)
        {
            query = query.Include(x=>x.User).Include(x => x.CartItems).ThenInclude(x=>x.Product).ThenInclude(x=>x.Assets);
             if (!string.IsNullOrEmpty(search.FTS))
            {
                query = query.Where(x=>x.User.Username==search.FTS);
            }

            return query;
        }
        protected override async Task BeforeInsert(Cart entity, CartRequest request)
        {
            
        }

        public override async Task<CartResponse> CreateAsync(CartRequest request)
        {
            if (string.IsNullOrEmpty(request.username))
            {
                throw new UserException("There is no username");
            }
            
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == request.username);
            if (user == null)
            {
                throw new UserException("User not found");
            }

            // Find existing cart for this user (include cart items for updating)
            var cart = await _context.Carts
                .Include(c => c.CartItems).ThenInclude(x=>x.Product)
                .FirstOrDefaultAsync(x => x.UserId == user.Id);

            if (cart.isCheckout == true)
            {
                throw new UserException();
            }

            if (cart == null)
            {
                // Create new cart if doesn't exist
                cart = new Cart
                {
                    UserId = user.Id,
                    CreatedAt = DateTime.UtcNow
                };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync(); // Save to get cart ID
            }

            // Process each cart item from request
            foreach (var itemRequest in request.CartItems)
            {
                // Find existing cart item for this product
                var existingCartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == itemRequest.ProductId);

                if (itemRequest.Quantity <= 0)
                {
                    // Remove item if quantity is 0 or negative
                    if (existingCartItem != null)
                    {
                        var cartEventReq= new CartEventIB200116Request
                        {
                          CartId=cart.Id,
                          CartItemId=null,
                          Username=user.Username,
                          EventType="Uklanjanje produkta",
                          ProductPrice=existingCartItem.Product.Price,
                          ProductName = existingCartItem.Product.Name,
                          PreviousQuantity = existingCartItem.Quantity,
                          NewQuantity = 0
                        };
                        await _cartEventService.CreateAsync(cartEventReq);
                        _context.CartItems.Remove(existingCartItem);
                    }
                }
                else
                {
                    if (existingCartItem != null)
                    {
                         var cartEventReq= new CartEventIB200116Request
                        {
                          CartId=cart.Id,
                          CartItemId=existingCartItem.Id,
                          Username=user.Username,
                          EventType="Promjena kolicine",
                          ProductPrice=existingCartItem.Product.Price,
                          ProductName = existingCartItem.Product.Name,
                          PreviousQuantity = existingCartItem.Quantity,
                          NewQuantity = itemRequest.Quantity
                        };
                        await _cartEventService.CreateAsync(cartEventReq);
                        // Update existing item quantity
                        existingCartItem.Quantity = itemRequest.Quantity;
                        existingCartItem.UpdatedAt = DateTime.UtcNow;
                    }
                    else
                    {
                        // Add new item to cart
                        var newCartItem = new CartItem
                        {
                            CartId = cart.Id,
                            ProductId = itemRequest.ProductId,
                            Quantity = itemRequest.Quantity,
                            AddedAt = DateTime.UtcNow
                        };
                       
                        cart.CartItems.Add(newCartItem);

                        await  _context.SaveChangesAsync();
                        var cartItem =await _context.CartItems.Include(x=>x.Product).FirstOrDefaultAsync(x=>x.ProductId==newCartItem.ProductId);
                        var cartEventReq= new CartEventIB200116Request
                        {
                          CartId=cart.Id,
                          CartItemId=cartItem.Id,
                          Username=user.Username,
                          EventType="Dodavanje proizvoda",
                          ProductPrice=cartItem.Product.Price,
                          ProductName = cartItem.Product.Name,
                          PreviousQuantity = 0,
                          NewQuantity = cartItem.Quantity
                        };
                        await _cartEventService.CreateAsync(cartEventReq);
                    }
                }
            }

            cart.UpdatedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            // Reload cart with full data for response
            var updatedCart = await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.Id == cart.Id);

            return MapToResponse(updatedCart);
        }
        protected override async Task BeforeUpdate(Cart entity, CartRequest request)
        {
            entity.UpdatedAt = DateTime.Now;
            entity.isCheckout = true;
        }

        public async Task Checkout(int id)
        {
            var cart =await _context.Carts.FirstOrDefaultAsync(x=>x.Id==id);
            if (cart == null)
            {
                throw new KeyNotFoundException();
            }
            cart.isCheckout=true;
            cart.UpdatedAt=DateTime.UtcNow;
            _context.SaveChanges();
        }

    }
}