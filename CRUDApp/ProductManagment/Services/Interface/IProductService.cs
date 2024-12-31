using ProductManagment.Models;

namespace ProductManagment.Services.Interface
{
    public interface IProductService
    {
      public  Task<bool> AddProduct(Product product);
        public Task<bool> UpdateProduct(Product product);
        public Task<bool> DeleteProduct(Guid id);
        public Task<Product> GetProduct(Guid id);
        public Task<List<Product>> GetAllProducts();
    }
}
