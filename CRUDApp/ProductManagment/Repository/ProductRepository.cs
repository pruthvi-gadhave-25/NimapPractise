using ProductManagment.Models;
using ProductManagment.Repository.Interface;
using ProductManagment.Data ;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;
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
                var product = await _context.Products.FirstOrDefaultAsync(prod => prod.ProductId == id);

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

                 //var product = _context.Products.FirstOrDefault( p => p.ProductId  == )
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
                //var product = await _context.Products.Include(c => c.Category)
                //    .FirstOrDefaultAsync( p=> p.ProductId == id); //Eager Loading 
                Console.WriteLine("Query On Console");
                var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
                //Console.WriteLine($"products  with category :{product.Category.CategoryName} " );
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
//Lazy loading
// https://dotnettutorials.net/lesson/lazy-loading-in-entity-framework-core/#:~:text=For%20Lazy%20Loading%20to%20work,mechanism%20when%20they%20are%20accessed.


//Use Eager Loading when:

//You know in advance that the related data is always required.
//You want to avoid multiple round trips to the database and ensure all necessary data is fetched in a single query.
//You are dealing with batch processing or report generation, where all related data is needed upfront.

//Use Lazy Loading when:

//You don’t always need the related data and want to defer loading until the data is explicitly accessed.
//You want to minimize the initial query size and only load related data as needed.
//You are working with user-triggered actions, loading related data based on user interaction (e.g., expanding a section in the UI to view related information).