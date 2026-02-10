using System;

namespace eCommerce.Model.Responses
{
    public class CartItemResponse
    {
         public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public ProductResponse Product { get; set; } = null!;
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}