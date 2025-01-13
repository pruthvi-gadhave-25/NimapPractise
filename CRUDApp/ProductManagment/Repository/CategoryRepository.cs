using Microsoft.EntityFrameworkCore;
using ProductManagment.Data;
using ProductManagment.Models;
using ProductManagment.Repository.Interface;

namespace ProductManagment.Repository
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddCategory(Category category)
        {
            try
            {
                var res = await  _context.AddAsync(category);
                await _context.SaveChangesAsync();
                return true ;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }




        public async Task<bool> DeleteCategory(int id)
        {
            try
            {
                var category = await _context.Categories.FirstOrDefaultAsync(category => category.CategoryId == id);

                if (category == null)
                {
                    return false;
                }
                var res = _context.Categories.Remove(category);
                _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<List<Category>> GetAllCategories()
        {
            try
            {
               return   await  _context.Categories.ToListAsync();
              
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Category> GetCategory(int id)
        {   
            return await _context.Categories.FindAsync(id);
        }

        public async Task<bool> UpdateCategory(Category category)
        {
            try
            {
                _context.Update(category);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task SaveAsync()
        {
            _context.SaveChangesAsync();

           
        }

      public async Task<List<Product>> GetProductsByCategory(int categoryId){

            var products = await _context.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
            return products;
       }

        
    }
}
