using EcomMvc.Data;
using EcomMvc.Models;
using EcomMvc.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcomMvc.Repository
{
    public class CategoyRepository : ICategoryRepositoy
    {

        private readonly AppDbContext _context;


        public CategoyRepository(AppDbContext context)
        {
            _context = context;
        }


        //public async Task<List<Category>> GetAllCategories()
        //{
        //    //List<Category> categories = await _context.Categories.ToListAsync();
        //    //return categories;

        //    var categories = _context.Categories.FromSqlRaw<Category>("GetAllCategories").ToList();
        //    return categories; 

        }

    
}
