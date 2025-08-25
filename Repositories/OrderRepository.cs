using Data;
using Models;
using MongoDB.Driver;
using Repositories.IRepositories;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IMongoCollection<Order> _collection;

        public OrderRepository(MongoDbContext context)
        {
            _collection = context.Orders;
        }

        public async Task<IEnumerable<Order>> GetAllAsync() =>
            await _collection.Find(_ => true).ToListAsync();

        public async Task<Order?> GetByIdAsync(string id) =>
            await _collection.Find(p => p.Id == id).FirstOrDefaultAsync();

        public async Task AddAsync(Order order) => await _collection.InsertOneAsync(order);

        public async Task UpdateAsync(string id, Order order) =>
            await _collection.ReplaceOneAsync(p => p.Id == id, order);

        public async Task DeleteAsync(string id) =>
            await _collection.DeleteOneAsync(p => p.Id == id);
    }
}
