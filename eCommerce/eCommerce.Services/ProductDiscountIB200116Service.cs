using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
    public class ProductDiscountIB200116Service : BaseCRUDService<ProductDiscountIB200116Response,BaseSearchObject,ProductDiscountIB200116,ProductDiscountIB200116Request,ProductDiscountIB200116Request>
    {
        protected readonly eCommerceDbContext _context;
        protected readonly IMapper _mapper;
        public ProductDiscountIB200116Service(eCommerceDbContext context,IMapper mapper):base(context,mapper)
        {
            _context=context;
            _mapper=mapper;
        }

        protected override async Task BeforeInsert(ProductDiscountIB200116 entity, ProductDiscountIB200116Request request)
        {
            var obj = await _context.Products.FirstOrDefaultAsync(x => x.Id==entity.ProductId);
            obj.hasDiscount=true;
        }

        protected override IQueryable<ProductDiscountIB200116> ApplyFilter(IQueryable<ProductDiscountIB200116> query, BaseSearchObject search)
        {
            query=query.Include(x=>x.Product).ThenInclude(x=>x.Assets);
            if (!string.IsNullOrEmpty(search.FTS))
            {
                query = query.Where(p => p.Product.Name.Contains(search.FTS)&&p.Discount>0);
            }
            
            return query;
        }

    }
}