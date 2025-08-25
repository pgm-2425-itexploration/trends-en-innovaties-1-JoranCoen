using Models;
using Repositories.IRepositories;

namespace Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return await _orderRepository.GetAllAsync();
        }

        public async Task<Order?> GetOrderAsync(string id)
        {
            return await _orderRepository.GetByIdAsync(id);
        }

        public async Task CreateOrderAsync(Order order)
        {
            await _orderRepository.AddAsync(order);
        }

        public async Task UpdateOrderAsync(string id, Order order)
        {
            await _orderRepository.UpdateAsync(id, order);
        }

        public async Task DeleteOrderAsync(string id)
        {
            await _orderRepository.DeleteAsync(id);
        }
    }
}
