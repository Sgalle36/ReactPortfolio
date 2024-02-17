using Microsoft.EntityFrameworkCore;
using MyPortfolio.Server.Data.Models;
using System;
using System.Reflection.Metadata;

namespace MyPortfolio.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // Database Models
        public DbSet<Project> Projects { get; set; } // the physical db table

        // Database Seeder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new() { Id = 1, Name = "My Portfolio", Description = "An application with an ASP.NET API backend and React frontend." },
                new() { Id = 2, Name = "Cheaper by the Dozen", Description = "An ecommerce store built using the ASP.NET framework with Razor pages." }
            );
        }
    }
}
