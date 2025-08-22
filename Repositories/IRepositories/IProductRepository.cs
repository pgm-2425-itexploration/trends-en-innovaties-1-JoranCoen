using Models;

namespace Repositories.IRepositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(string id);
        Task AddAsync(Product product);
        Task UpdateAsync(string id, Product product);
        Task DeleteAsync(string id);
    }
}
