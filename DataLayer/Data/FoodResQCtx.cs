using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Data
{
    public class FoodResQCtx : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<FoodBox> Foodboxes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FoodResQDb");
        }
    }
}
