using ProductManagment.Models;

namespace ProductManagment.Repository.Interface
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUsers();
        public Task<User> GetUser(int id);

        public Task<bool> AddUser(User user);
      
    }
}
