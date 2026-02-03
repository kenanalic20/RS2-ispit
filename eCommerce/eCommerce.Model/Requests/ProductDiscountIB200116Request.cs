using System;

namespace eCommerce.Model.Requests
{
    public class ProductDiscountIB200116Request
    {
        
        public int? ProductId { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? BeganAt { get; set; }
        public DateTime? ValidUntil { get; set; }
    }
}