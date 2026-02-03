using System;

namespace eCommerce.Model.Responses
{
    public class ProductDiscountIB200116Response
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public ProductResponse? Product { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? BeganAt { get; set; }
        public DateTime? ValidUntil { get; set; }
    }
}