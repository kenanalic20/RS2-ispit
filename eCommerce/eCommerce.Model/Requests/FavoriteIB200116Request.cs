using System;
namespace eCommerce.Model.Requests
{
    public class FavoriteIB200116Request
    {
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public DateTime? addedAt { get; set; }
        public string username { get; set; }

    }
}