using eCommerce.Model.Responses;
using System;
namespace eCommerce.Model.Responses
{
    public class FavoriteIB200116Response
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public ProductResponse? Product { get; set; }
        public int? UserId { get; set; }
        public UserResponse? User { get; set; }
        public DateTime? addedAt { get; set; }
    }
}