using ProductManagment.Models;

namespace ProductManagment.Services.Interface
{
    public interface IUserService
    {
        public Task<bool> AddUser(User user);
      
        public Task<User> GetUser(int id);
        public Task<List<User>> GetAllUsers();
    }
}
