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
            modelBuilder.Ignore <SelectListItem>();


            //employee -  country
            modelBuilder.Entity<Employee>() 
                .HasOne(e => e.Country) //navigation prop 
                .WithMany()
                .HasForeignKey(e => e.CountryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Employee → State
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.State)
                .WithMany()
                .HasForeignKey(e => e.StateId)
                .OnDelete(DeleteBehavior.Cascade);

            // Employee → City
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.City)
                .WithMany()
                .HasForeignKey(e => e.CityId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
