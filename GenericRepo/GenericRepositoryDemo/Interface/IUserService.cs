using GenericRepositoryDemo.Models;

namespace GenericRepositoryDemo.Interface
{
    public interface IUserService
    {
        Task AddUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetById(int id);
    }
}
