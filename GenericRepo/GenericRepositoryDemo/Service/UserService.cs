using GenericRepositoryDemo.Interface;
using GenericRepositoryDemo.Models;

namespace GenericRepositoryDemo.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task AddUser(User user)
        {
             _repository.Add(user);
            await _repository.Save();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
          return await  _repository.GetAllAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}
