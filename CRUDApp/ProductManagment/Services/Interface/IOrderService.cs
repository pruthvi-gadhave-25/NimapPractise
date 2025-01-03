using ProductManagment.Models;

namespace ProductManagment.Services.Interface
{
    public interface IOrderService
    {
        Task<List<Order>> GetAllOrders();
        Task<bool>AddOrder(Order order);
    }
}
