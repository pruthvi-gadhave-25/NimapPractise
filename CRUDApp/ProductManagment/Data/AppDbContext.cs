using Microsoft.EntityFrameworkCore;
using ProductManagment.Models;

namespace ProductManagment.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }    

        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           

            modelBuilder.Entity<ProductOrder>()
            .HasKey(op => new { op.OrderId,op.ProductId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //this will eable lazy loading --> Pacjage Name (NUget)Microsoft.EntityFrameworkCore.Proxies
            optionsBuilder.UseLazyLoadingProxies()
                .LogTo(Console.WriteLine, LogLevel.Information);
            // then make Navigation Property as virtual  to support lazy loading 
        }
    }
}
