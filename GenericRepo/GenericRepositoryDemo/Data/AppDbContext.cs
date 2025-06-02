using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
