using ProductManagment.Models;
using ProductManagment.Repository.Interface;
using ProductManagment.Services.Interface;

namespace ProductManagment.Services
{
    public class UserService : IUserService
    {   
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async  Task<bool> AddUser(User user)
        {
            return await _userRepository.AddUser(user);
        }

        public async Task<List<User>> GetAllUsers()
        {
          return await _userRepository.GetAllUsers();
        }

        public async  Task<User> GetUser(int id)
        {
            return await _userRepository.GetUser(id);
        }
    }
}
