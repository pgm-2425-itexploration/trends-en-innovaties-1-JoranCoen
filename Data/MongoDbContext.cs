using Models;
using MongoDB.Driver;

namespace Data
{
    public class MongoDbContext
    {
        public IMongoDatabase Database { get; }
        public IMongoCollection<Product> Products => Database.GetCollection<Product>("Products");
        public IMongoCollection<Order> Orders => Database.GetCollection<Order>("Orders");

        public MongoDbContext(IConfiguration config, IMongoClient client)
        {
            var databaseName = Environment.GetEnvironmentVariable("MONGO_DB_NAME") ?? "BlazorTutorial";

            Database = client.GetDatabase(databaseName);
        }
    }
}
