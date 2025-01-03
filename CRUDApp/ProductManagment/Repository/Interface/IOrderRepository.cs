using ProductManagment.Models;

namespace ProductManagment.Repository.Interface
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrders() ;
        Task<bool> AddOrder(Order order);
    }
}
