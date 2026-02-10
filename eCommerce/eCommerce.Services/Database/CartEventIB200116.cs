using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Services.Database
{
    public class CartEventIB200116
    {
        public int Id { get; set; }
        public int? CartId { get; set; }
        public Cart? Cart { get; set; }
        public int? CartItemId { get; set; }
        public CartItem? CartItem { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public string? EventType { get; set; }
        public DateTime? CreatedAt { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ProductPrice { get; set; }
        public string? ProductName { get; set; }
        public int PreviousQuantity  { get; set; }
        public int NewQuantity  { get; set; }

    }
}