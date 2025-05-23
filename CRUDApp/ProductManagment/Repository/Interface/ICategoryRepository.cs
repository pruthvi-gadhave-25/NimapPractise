﻿using ProductManagment.Models;

namespace ProductManagment.Repository.Interface
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetAllCategories();
        public Task<Category> GetCategory(int id);

        public Task<bool> AddCategory(Category category);
        public Task<bool> UpdateCategory(Category category);
        public Task<bool> DeleteCategory(int id);

        public Task SaveAsync();
        Task<List<Product>> GetProductsByCategory(int categoryId);
        
    }
}
