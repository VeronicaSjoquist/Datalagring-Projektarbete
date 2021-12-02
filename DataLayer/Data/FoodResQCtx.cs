using System;
using System.Diagnostics;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Data
{
    public class FoodResQCtx : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<FoodBox> Foodboxes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .LogTo(c => Debug.WriteLine(c))
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProjektarbeteDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasIndex(e => e.Username).IsUnique();

            modelBuilder.Entity<Restaurant>()
                .HasIndex(e => e.Username).IsUnique();
        }
    }
}