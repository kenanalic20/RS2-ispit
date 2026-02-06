using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Services
{
    public class FavoriteIB200116Service : BaseCRUDService<FavoriteIB200116Response, FavoriteIB200116SearchObject, FavoriteIB200116, FavoriteIB200116Request, FavoriteIB200116Request>
    {
        private readonly eCommerceDbContext _context;
        private readonly IMapper _mapper;
        public FavoriteIB200116Service(eCommerceDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // protected override async Task BeforeInsert(FavoriteIB200116 entity, FavoriteIB200116Request request)
        // {
        //     if (!string.IsNullOrEmpty(request.username))
        //     {
        //         var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == request.username);
        //         entity.UserId = user.Id;
        //     }

        // }
        public override async Task<FavoriteIB200116Response> CreateAsync(FavoriteIB200116Request request)
        {
            var entity = new FavoriteIB200116();
            MapInsertToEntity(entity, request);

            if (!string.IsNullOrEmpty(request.username))
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == request.username);
                entity.UserId = user.Id;
            }

            var existingFavorite = await _context.FavoriteIB200116s
                .FirstOrDefaultAsync(x => x.ProductId == request.ProductId && x.UserId == entity.UserId);

            if (existingFavorite != null)
            {

                _context.FavoriteIB200116s.Remove(existingFavorite);
                await _context.SaveChangesAsync();
                return null; // Favorite removed
            }

            await _context.FavoriteIB200116s.AddAsync(entity);
            await _context.SaveChangesAsync();
            return MapToResponse(entity);
        }
        protected override FavoriteIB200116Response MapToResponse(FavoriteIB200116 entity)
        {
            var response = base.MapToResponse(entity);

            // Set IsFavorite to true since these are favorited products
            if (response.Product != null)
            {
                response.Product.IsFavorite = true;
            }

            return response;
        }

        protected override IQueryable<FavoriteIB200116> ApplyFilter(IQueryable<FavoriteIB200116> query, FavoriteIB200116SearchObject search)
        {
            query = query.Include(x => x.User).Include(x => x.Product).ThenInclude(x => x.Assets).Where(x => x.User.Username == search.username);
            if (search.to != null && search.from != null)
            {
                query = query.Where(x => x.addedAt >= search.from && x.addedAt <= search.to);
            }
            return query;
        }
    }
}