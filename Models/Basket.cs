using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Basket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public ICollection<BasketItem> Items { get; set; } = new List<BasketItem>();
    }

    public class BasketItem
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public required string ProductId { get; set; }
        public int Quantity { get; set; } = 1;
        public Product? Product { get; set; }
    }
}
