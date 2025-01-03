using Microsoft.EntityFrameworkCore;
using ProductManagment.Data;
using ProductManagment.Models;
using ProductManagment.Repository.Interface;

namespace ProductManagment.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

       public async  Task<bool> AddOrder(Order order)
        {
          await  _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Order>>GetAllOrders()
        {
            return await _context.Orders.Include(o => o.ProductOrders).ToListAsync();
        }
    }
}
