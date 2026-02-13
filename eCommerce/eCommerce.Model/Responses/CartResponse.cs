using System;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce.Model.Responses
{
    public class CartResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        
        // Items in cart
        public List<CartItemResponse> CartItems { get; set; } = new List<CartItemResponse>();
        
        public bool isCheckout { get; set; }
    }
}