using ProductManagment.Models;
using ProductManagment.Services.Interface;
using ProductManagment.Repository.Interface;

namespace ProductManagment.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository; 

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }



        public Task<bool> AddCategory(Category category)
        {
            return _categoryRepository.AddCategory(category);
        }

        public Task<bool> DeleteCategory(int id)
        {
            return _categoryRepository.DeleteCategory(id);
        }

        public Task<List<Category>> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public Task<Category> GetCategory(int id)
        {
            return _categoryRepository.GetCategory(id);
        }

        public Task<bool> UpdateCategory(Category category)
        {
            return _categoryRepository.UpdateCategory(category);
        }

        public async  Task DeactivateCategory(int categoryId)
        {
            var category = await  _categoryRepository.GetCategory(categoryId);

            category.IsActive = false;

            var products = await _categoryRepository.GetProductsByCategory(categoryId);

            foreach( var product in products)
            {
                product.isActive = false;    
            }

            await _categoryRepository.SaveAsync();

        }

        public async Task ActivateCategory(int categoryId)
        {
            var category = await _categoryRepository.GetCategory(categoryId);

            category.IsActive = true;

            var products = await _categoryRepository.GetProductsByCategory(categoryId);

            foreach (var product in products)
            {
                product.isActive = true;
            }

            await _categoryRepository.SaveAsync();
        }
    }
}
