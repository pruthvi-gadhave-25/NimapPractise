using ProductManagment.Models;
using ProductManagment.Repository;
using ProductManagment.Repository.Interface;
using ProductManagment.Services.Interface;

namespace ProductManagment.Services
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository _orderRepository;
        public OrderService( IOrderRepository orderRepository) 
        { 
            _orderRepository = orderRepository;
        }

        public async Task<bool> AddOrder(Order order)
        {
           return await _orderRepository.AddOrder(order);
        }

        public async Task<List<Order>> GetAllOrders()
        {
          return await _orderRepository.GetAllOrders();
        }
    }
}
