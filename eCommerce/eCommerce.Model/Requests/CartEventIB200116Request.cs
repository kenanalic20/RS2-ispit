using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace eCommerce.Model.Requests
{
    public class CartEventIB200116Request
    {
        public int? CartId { get; set; }
        public int? UserId { get; set; }
        public string? EventType { get; set; }
        public DateTime? CreatedAt { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ProductPrice { get; set; }

        public string? ProductName { get; set; }
        public int PreviousQuantity  { get; set; }
        public int NewQuantity  { get; set; }

    }
}