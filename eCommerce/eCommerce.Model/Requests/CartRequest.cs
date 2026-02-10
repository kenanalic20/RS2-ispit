using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce.Model.Requests{
    public class CartRequest
    {
        public string? username { get; set; }
        public List<CartItemRequest> CartItems { get; set; } = new List<CartItemRequest>();
    }
} 