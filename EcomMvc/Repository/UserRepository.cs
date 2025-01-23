using EcomMvc.Data;
using EcomMvc.Models;
using EcomMvc.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace EcomMvc.Repository
{
    public class UserRepository : IUserRepository
    {
            private readonly AppDbContext _context  ;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        //Registration
        public async  Task<bool> AddUser(User user)
        {
            if(user !=null)
            {
                await  _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<User> GetValidUser(string userName , string password)
        {

           var user = await  _context.Users.FirstOrDefaultAsync( u => (u.UserName  == userName) && (u.Password == password));

            return user;
        }


        public async Task<bool> Login(LoginViewModel model)
        {
            try
            {
                await _context.AddAsync(model);
                await _context.SaveChangesAsync();

                return true  ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return false;
        }
    }
}
