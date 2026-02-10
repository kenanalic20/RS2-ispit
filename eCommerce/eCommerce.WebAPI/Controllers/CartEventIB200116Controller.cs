using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;

namespace eCommerce.WebAPI.Controllers
{
    public class CartEventIB200116Controller:BaseCRUDController<CartEventIB200116Response,BaseSearchObject,CartEventIB200116Request,CartEventIB200116Request>
    {
        protected readonly CartEventIB200116Service _service;
        public CartEventIB200116Controller(CartEventIB200116Service service):base(service)
        {
            _service=service;
        }
    }
}