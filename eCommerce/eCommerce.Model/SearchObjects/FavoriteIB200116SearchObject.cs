using System;
namespace eCommerce.Model.SearchObjects
{
    public class FavoriteIB200116SearchObject:BaseSearchObject
    {
        public string username { get; set; }
        public DateTime? from { get; set; }
        public DateTime? to { get; set; }
    }
}