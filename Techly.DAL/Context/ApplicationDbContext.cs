using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    public class ApplicationDbContext: IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Mobile Accessories", DisplayOrder = 1 },
                 new Category { Id = 2, Name = "Power & Charging", DisplayOrder = 2 },
                 new Category { Id = 3, Name = "Headphones & Audio", DisplayOrder = 3 },
                 new Category { Id = 4, Name = "Smart Gadgets", DisplayOrder = 4 },
                 new Category { Id = 5, Name = "Laptops & PCs", DisplayOrder = 5 }
            );

            // Seed Products
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
                    CategoryId = 5
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
                    CategoryId = 4
                },
                new Product
                {
                    Id = 3,
                    Title = "Sony WH-1000XM5",
                    Description = "Noise-cancelling wireless headphones",
                    SKU = "AUD-001",
                    Brand = "Sony",
                    ListPrice = 12000,
                    Price = 11500,
                    Price50 = 11000,
                    Price100 = 10500,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 4,
                    Title = "Logitech MX Master 3",
                    Description = "Advanced wireless mouse",
                    SKU = "ACC-002",
                    Brand = "Logitech",
                    ListPrice = 3000,
                    Price = 2800,
                    Price50 = 2600,
                    Price100 = 2500,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 5,
                    Title = "HP Spectre x360",
                    Description = "2-in-1 convertible laptop",
                    SKU = "LAP-002",
                    Brand = "HP",
                    ListPrice = 27000,
                    Price = 26000,
                    Price50 = 25000,
                    Price100 = 24000,
                    CategoryId = 5
                },
                new Product
                {
                    Id = 6,
                    Title = "Apple AirPods Pro 2",
                    Description = "True wireless earbuds with ANC",
                    SKU = "AUD-002",
                    Brand = "Apple",
                    ListPrice = 9500,
                    Price = 9200,
                    Price50 = 8900,
                    Price100 = 8600,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 7,
                    Title = "Baseus Car Charger",
                    Description = "Dual USB fast car charger",
                    SKU = "CHG-001",
                    Brand = "Baseus",
                    ListPrice = 700,
                    Price = 650,
                    Price50 = 600,
                    Price100 = 550,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 8,
                    Title = "Xiaomi Smart Band 7",
                    Description = "Fitness tracker with AMOLED display",
                    SKU = "GAD-002",
                    Brand = "Xiaomi",
                    ListPrice = 2000,
                    Price = 1900,
                    Price50 = 1800,
                    Price100 = 1700,
                    CategoryId = 4
                },
                   new Product
                   {
                       Id = 9,
                       Title = "Samsung Galaxy Watch 5",
                       Description = "Smartwatch with health tracking",
                       SKU = "GAD-001",
                       Brand = "Samsung",
                       ListPrice = 8000,
                       Price = 7700,
                       Price50 = 7400,
                       Price100 = 7100,
                       CategoryId = 4
                   },
                   new Product
                   {
                       Id = 10,
                       Title = "Anker Power Bank 20000mAh",
                       Description = "Fast charging portable power bank",
                       SKU = "ACC-001",
                       Brand = "Anker",
                       ListPrice = 1500,
                       Price = 1400,
                       Price50 = 1300,
                       Price100 = 1200,
                       CategoryId = 2
                   }

            );
        }
    }
}
