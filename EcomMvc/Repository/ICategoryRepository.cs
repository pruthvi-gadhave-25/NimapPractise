using EcomMvc.Models;

namespace EcomMvc.Repository
{
    public interface ICategoryRepository
    {

        public Task<List<Category>> GetAllCategories();
    }
}
