using Models.Shared;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();
        public required string FullName { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string PostalCode { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    }

    public class OrderItem
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public required string ProductId { get; set; }
        public int Quantity { get; set; }
        public Product? Product { get; set; }
    }
}
