using ProductManagment.Services.Interface;
using ProductManagment.Repository;
using ProductManagment.Models;
using ProductManagment.Repository.Interface;

namespace ProductManagment.Services
{
    public class ProductService :IProductService
    { 
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

       public Task<bool>AddProduct(Product product)
        { 
            
        Console.WriteLine(product);
           return _productRepository.AddProduct(product);
        }

       public Task<bool> DeleteProduct(Guid id)
        {
            return  _productRepository.DeleteProduct(id);
        }

       public  async Task<List<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts();
        }

       public  Task<Product> GetProduct(Guid id)
        {
           return _productRepository.GetProduct(id);
        }

        public Task<bool> UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }
    }
}
