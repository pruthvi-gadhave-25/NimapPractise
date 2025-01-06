using System.Security.Cryptography.Xml;
using AuthenticationDemo.Models;

namespace AuthenticationDemo.Repository
{
    public class UserRepository : IUserRepository
    {

        private List<User> users = new List<User>
            {
              
                new User { Id = 1, Username = "admin", Password = "admin" },
                new User { Id = 2, Username = "user", Password = "user" },
                new User { Id = 3, Username = "Pranaya", Password = "Test@1234" },
                new User { Id = 4, Username = "Kumar", Password = "Admin@123" }
            };
        public async Task<User?> AddUser(User user)
        {
            await Task.Delay(100);
            if(users.Any( u => u.Id == user.Id)){ 
                throw new Exception("user not added ");
            }
             users.Add(user);
            return user;
        }

        public  async Task DeleteUser(int id)
        {
            await Task.Delay(100); 
            var user = await GetUserById(id); 

            if (user == null)
            {
                throw new Exception("User not found."); 
            }
            users.Remove(user);
        }

        public async  Task<List<User?>> GetAllUsers()
        {
           Task.Delay(100);

            return users.ToList();
        }

        public async Task<User?> GetUserById(int id)
        {
            await Task.Delay(100);
            return users.FirstOrDefault(u => u.Id == id);
        }

        public async  Task<User> UpdateUser(User user)
        {
            await Task.Delay(100);
            var existingUser = await GetUserById(user.Id); 
            if (existingUser == null)
            {
                throw new Exception("User not found."); 
            }
           existingUser.Id = user.Id;
           existingUser.Username = user.Username;

            return user;
        }

        public async Task<User?> ValidateUser(string username, string password)
        {
            await Task.Delay(100); // Simulates a delay, mimicking database latency.
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
