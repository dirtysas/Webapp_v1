using WebApp.DAL.Entities;
using WebApp.BLL.Services;
using WebApp.DAL.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository) => _orderRepository = orderRepository;

        public async Task<List<Order>> GetAllOrdersAsync() => await _orderRepository.GetAllAsync();
        public async Task<Order> GetOrderByIdAsync(int id) => await _orderRepository.GetByIdAsync(id);
        public async Task CreateOrderAsync(Order order) => await _orderRepository.AddAsync(order);
        public async Task UpdateOrderAsync(Order order) => await _orderRepository.UpdateAsync(order);
        public async Task DeleteOrderAsync(int id) => await _orderRepository.DeleteAsync(id);
    }
}