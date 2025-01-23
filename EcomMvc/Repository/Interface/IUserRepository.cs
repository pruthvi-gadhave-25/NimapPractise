using EcomMvc.Models;

namespace EcomMvc.Repository.Interface
{
    public interface IUserRepository
    {

        public Task<bool> AddUser( User user);
        public Task<User> GetValidUser(string userName ,string password);
        public Task<bool> Login(LoginViewModel model);
    }
}
