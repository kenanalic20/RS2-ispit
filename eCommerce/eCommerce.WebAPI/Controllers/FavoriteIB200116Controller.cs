using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;

namespace eCommerce.WebAPI.Controllers
{
    public class FavoriteIB200116Controller:BaseCRUDController<FavoriteIB200116Response,FavoriteIB200116SearchObject,FavoriteIB200116Request,FavoriteIB200116Request>
    {
        public FavoriteIB200116Controller(FavoriteIB200116Service service):base(service)
        {
        }
    }
}