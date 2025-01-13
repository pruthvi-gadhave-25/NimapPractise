using Microsoft.EntityFrameworkCore;
using ProductManagment.Data;
using ProductManagment.Models;
using ProductManagment.Repository.Interface;

namespace ProductManagment.Repository
{   
   
    public class UserRepository : IUserRepository
    {

        private readonly AppDbContext _context;


        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddUser(User user)
        {
            try
            {
        
                if(user == null)
                {
                    return false;
                }
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return true;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

       

        public async  Task<List<User>> GetAllUsers()
        {
            var users = await   _context.Users.ToListAsync();
           if(users == null)
            {
                return null;

            }
            return users;
        }

       

         public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

           
            return user;
        }
    }
}
