using ProductManagment.Models;

namespace ProductManagment.Repository.Interface
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllProducts();
        public Task<Product> GetProduct(Guid id);

        public Task<bool> AddProduct(Product product);
        public Task<bool> UpdateProduct(Product product);
        public Task<bool> DeleteProduct(Guid id);
    }
}
