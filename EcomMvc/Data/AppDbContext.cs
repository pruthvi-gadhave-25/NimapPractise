using EcomMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace EcomMvc.Data
{
    public class AppDbContext  :DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


       public  DbSet<Product>Products {  get; set; }
        public  DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


           
        }

    }
}
