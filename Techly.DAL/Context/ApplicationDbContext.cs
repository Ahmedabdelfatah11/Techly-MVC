using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techly.DAL.Models;

namespace Techly.DAL.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Product>  Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Mobile Accessories", DisplayOrder = 1 },
                 new Category { Id = 2, Name = "Power & Charging", DisplayOrder = 2 },
                 new Category { Id = 3, Name = "Headphones & Audio", DisplayOrder = 3 },
                 new Category { Id = 4, Name = "Smart Gadgets", DisplayOrder = 4 }
            );

            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  Id = 1,
                  Title = "Dell XPS 13",
                  Description = "13-inch laptop with InfinityEdge display",
                  SKU = "LAP-001",
                  Brand = "Dell",
                  ListPrice = 25000,
                  Price = 24000,
                  Price50 = 23000,
                  Price100 = 22000,
                  //ImageUrl = "/images/products/dell-xps-13.jpg",
                  CategoryId = 1
              },
    new Product
    {
        Id = 2,
        Title = "iPhone 14 Pro",
        Description = "Apple smartphone with A16 Bionic chip",
        SKU = "PHN-001",
        Brand = "Apple",
        ListPrice = 35000,
        Price = 34000,
        Price50 = 33000,
        Price100 = 32000,
        //ImageUrl = "/images/products/iphone14pro.jpg",
        CategoryId = 2
    },
    new Product
    {
        Id = 3,
        Title = "Anker Power Bank 20000mAh",
        Description = "Fast charging portable power bank",
        SKU = "ACC-001",
        Brand = "Anker",
        ListPrice = 1500,
        Price = 1400,
        Price50 = 1300,
        Price100 = 1200,
        //ImageUrl = "/images/products/anker-powerbank.jpg",
        CategoryId = 3
    }
               );
        }
    }
}
