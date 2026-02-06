namespace eCommerce.Services.Database
{
    public class FavoriteIB200116
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public DateTime? addedAt { get; set; }
    }
}