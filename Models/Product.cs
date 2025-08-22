using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public required string ImageUrl { get; set; }
        public ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();
    }

    public class ProductDetail
    {
        public required string Label { get; set; }
        public required string Value { get; set; }
    }
}
