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
        public DbSet<Company>  Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

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
            // Seed Companies
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "Techly Solutions",
                    StreetAdress = "123 Nile St.",
                    City = "Giza",
                    State = "GZ",
                    PostalCode = "12511",
                    PhoneNumber = "01000000001",
                },
                new Company
                {
                    Id = 2,
                    Name = "Smart Gadgets Co.",
                    StreetAdress = "45 Smart Village",
                    City = "Cairo",
                    State = "C",
                    PostalCode = "11835",
                    PhoneNumber = "01000000002"
                },
                new Company
                {
                    Id = 3,
                    Name = "Future Electronics",
                    StreetAdress = "78 Tahrir Square",
                    City = "Cairo",
                    State = "C",
                    PostalCode = "11511",
                    PhoneNumber = "01000000003"
                },
                new Company
                {
                    Id = 4,
                    Name = "NextGen Devices",
                    StreetAdress = "12 Corniche Rd.",
                    City = "Alexandria",
                    State = "ALX",
                    PostalCode = "21919",
                    PhoneNumber = "01000000004"
                }
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
                    CategoryId = 5,
                    ImageUrl = "\\images\\products\\7b9d5466-63ae-4677-8708-2ee746e4def6.jpg"
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
                    CategoryId = 4,
                    ImageUrl= "\\images\\products\\e33ddb5e-ca89-4170-b800-8def13749329.webp"
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
                    CategoryId = 3,
                    ImageUrl= "images/products/79062201-5c25-4de0-9e10-3fc5153fb4f5.webp"
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
                    CategoryId = 1,
                    ImageUrl = "images/products/57595f92-e108-4ba1-b562-da3d95056a22.png"
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
                    CategoryId = 5,
                    ImageUrl = "images/products/5792afe8-6bdd-4356-8fc3-4c1b6217c6d2.jpg"
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
                    CategoryId = 3,
                    ImageUrl = "images/products/0493017b-a468-4e7b-b951-4b48c3e33728.png"
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
                    CategoryId = 2,
                    ImageUrl = "images/products/81155a81-825c-4d08-b3bf-d2f3a9182abf.jpg"
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
                    CategoryId = 4,
                    ImageUrl = "images/products/9d27ef06-7799-451d-9bd2-45c4e47680ad.webp"
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
                       CategoryId = 4,
                       ImageUrl = "images/products/8d9aa883-5612-4056-b0b6-f526aeefbff6.webp"
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
                       CategoryId = 2,
                       ImageUrl = "images/products/0e7bc177-a2f9-4d0e-8efb-9a6c0629002e.webp"
                   }

            );
        }
    }
}
