using Data;
using Models;
using MongoDB.Driver;
using Repositories.IRepositories;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMongoCollection<Product> _collection;

        public ProductRepository(MongoDbContext context)
        {
            _collection = context.Products;
        }

        public async Task<IEnumerable<Product>> GetAllAsync() =>
            await _collection.Find(_ => true).ToListAsync();

        public async Task<Product?> GetByIdAsync(string id) =>
            await _collection.Find(p => p.Id == id).FirstOrDefaultAsync();

        public async Task AddAsync(Product product) => await _collection.InsertOneAsync(product);

        public async Task UpdateAsync(string id, Product product) =>
            await _collection.ReplaceOneAsync(p => p.Id == id, product);

        public async Task DeleteAsync(string id) =>
            await _collection.DeleteOneAsync(p => p.Id == id);
    }
}
