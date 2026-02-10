using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;

namespace eCommerce.WebAPI.Controllers
{
    public class CartController:BaseCRUDController<CartResponse,BaseSearchObject,CartRequest,CartRequest>
    {
        protected readonly CartService _service;
        public CartController(CartService service):base(service)
        {
            _service = service;
        }
    }
}