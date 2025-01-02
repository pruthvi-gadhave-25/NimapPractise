using ProductManagment.Models;
using ProductManagment.Repository.Interface;
using ProductManagment.Data ;
using Microsoft.EntityFrameworkCore;
namespace ProductManagment.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;


        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

      public  async  Task<bool> AddProduct(Product product)
        {
            try
            {
                var category = await _context.Categories.FindAsync(product.CategoryId);

                if(category == null)
                {
                    return false;
                }
                product.Category = category;

                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

       public async  Task<bool> DeleteProduct(Guid id)
        {
            try
            {
                var product = await _context.Products.FirstOrDefaultAsync(prod => prod.Id == id);

                if (product == null)
                {
                    return false;
                }
                var res =  _context.Products.Remove(product);
                _context.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<List<Product>> GetAllProducts()
        {
            try
            {
                var products =  await _context.Products.Include(c => c.Category).ToListAsync();
                return products;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

       public async  Task<Product> GetProduct(Guid id)
        {
            try
            {
                var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
                return product;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            throw new NotImplementedException();
        }

        public async Task<bool>UpdateProduct(Product product)
        {
            try
            {
                _context.Update(product);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<List<Product>> GetProductListByPagination(int page, int pageSize)
        {
            var products = await _context.Products.Include(c => c.Category).Skip((page-1) * pageSize).Take(pageSize).ToListAsync() ;

            return products;
        }
    }
}
