using eCommerce.Model.Requests;
using eCommerce.Model.Responses;
using eCommerce.Model.SearchObjects;
using eCommerce.Services;

namespace eCommerce.WebAPI.Controllers
{
    public class ProductDiscountIB200116Controller:BaseCRUDController<ProductDiscountIB200116Response,BaseSearchObject,ProductDiscountIB200116Request,ProductDiscountIB200116Request>
    {
        protected readonly ProductDiscountIB200116Service _service;
        public ProductDiscountIB200116Controller(ProductDiscountIB200116Service service):base(service)
        {
            _service=service;
        }
        
    }
}