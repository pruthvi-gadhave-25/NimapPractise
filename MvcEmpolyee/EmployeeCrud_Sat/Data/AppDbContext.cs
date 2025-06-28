using EmployeeCrud_Sat.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud_Sat.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee>Employees { get; set; }
        public DbSet<Country>Country { get; set; }
        public DbSet<City>Cities { get; set; }
        public DbSet<State>States { get; set; }
    }
}
