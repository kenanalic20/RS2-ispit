using System;

namespace eCommerce.Model.Responses
{
    public class CartEventIB200116Response
    {
        public int Id { get; set; }
        public int? CartId { get; set; }
        public CartResponse? Cart { get; set; }
        public int? UserId { get; set; }
        public UserResponse? User { get; set; }
        public string? EventType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public double Total { get; set; }
        public string? ProductName { get; set; }
        public int PreviousQuantity  { get; set; }
        public int NewQuantity  { get; set; }

    }
}