using DemoMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoMvc.Data
{   
    public class StudentContext : DbContext
    {
       public StudentContext( DbContextOptions<StudentContext> options): base(options) { }
        //public DbSet<Movie> Movies { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
