﻿using ProductManagment.Models;

namespace ProductManagment.Services.Interface
{
    public interface ICategoryService 
    {
        Task<bool> AddCategory(Category category);
        Task<bool> UpdateCategory(Category category);
        Task<bool> DeleteCategory(int id);
        Task<Category> GetCategory(int id);
        Task<List<Category>> GetAllCategories();
        Task DeactivateCategory(int categoryId);
        Task ActivateCategory(int categoryId);
      
       
    }
}
