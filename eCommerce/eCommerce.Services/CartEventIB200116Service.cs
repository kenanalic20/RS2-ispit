using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
    public class CartEventIB200116Service:BaseCRUDService<CartEventIB200116Response,BaseSearchObject,CartEventIB200116,CartEventIB200116Request,CartEventIB200116Request>
    {
        protected readonly eCommerceDbContext _context;
        public CartEventIB200116Service(eCommerceDbContext context,IMapper mapper):base(context,mapper)
        {
            _context=context;
        }
        
        protected override IQueryable<CartEventIB200116> ApplyFilter(IQueryable<CartEventIB200116> query, BaseSearchObject search)
        {
            return query.Include(x=>x.Cart).ThenInclude(x=>x.CartItems).Include(x=>x.User);
        }

        // protected override async Task BeforeInsert(CartEventIB200116 entity,CartEventIB200116Request request)
        // {
        //     entity.CreatedAt=DateTime.Now;
        //     entity.EventType="Dodavanje proizvoda";
        // }
        // protected virtual async Task BeforeUpdate(CartEventIB200116 entity, CartEventIB200116Request request)
        // {
        //     entity.EventType="Promjena količine";
        // }

    }
}