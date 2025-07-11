using EmployeeCrud_Sat.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrud_Sat.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Employee>Employees { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<SelectListGroup>();
            modelBuilder.Ignore<SelectListItem>();

            // Employee → Country
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Country)
                .WithMany(c => c.Employees) // navigation collection in Country class
                .HasForeignKey(e => e.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee → State
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.State)
                .WithMany(s => s.Employees) // navigation collection in State class
                .HasForeignKey(e => e.StateId)
                .OnDelete(DeleteBehavior.Restrict);

            // Employee → City
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.City)
                .WithMany(c => c.Employees) // navigation collection in City class
                .HasForeignKey(e => e.CityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
