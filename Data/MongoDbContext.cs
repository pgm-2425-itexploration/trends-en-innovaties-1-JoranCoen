using Models;
using MongoDB.Driver;

namespace Data
{
    public class MongoDbContext
    {
        public IMongoDatabase Database { get; }
        public IMongoCollection<Product> Products => Database.GetCollection<Product>("Products");

        public MongoDbContext(IConfiguration config, IMongoClient client)
        {
            string databaseName =
                config.GetValue<string>("MongoDbSettings:DatabaseName")
                ?? Environment.GetEnvironmentVariable("MONGO_DB_NAME")
                ?? throw new ArgumentNullException(
                    "MongoDbSettings:DatabaseName configuration is missing."
                );

            Database = client.GetDatabase(databaseName);
        }
    }
}
