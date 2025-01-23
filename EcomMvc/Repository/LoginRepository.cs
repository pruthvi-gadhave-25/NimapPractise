using System;
using EcomMvc.Data;
using EcomMvc.Models;

namespace EcomMvc.Repository
{
    public class LoginRepository
    {

        private readonly AppDbContext _context;

        public LoginRepository(AppDbContext context)
        {
            _context = context;
        }

    }
}
