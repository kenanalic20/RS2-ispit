using System.ComponentModel.DataAnnotations;

namespace eCommerce.Services.Database
{
    public class ProductDiscountIB200116
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        [Range(0,1)]
        public decimal? Discount { get; set; }
        public DateTime? BeganAt { get; set; }
        public DateTime? ValidUntil { get; set; }
    }
}