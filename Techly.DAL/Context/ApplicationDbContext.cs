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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Mobile Accessories", DisplayOrder = 1 },
                 new Category { Id = 2, Name = "Power & Charging", DisplayOrder = 2 },
                 new Category { Id = 3, Name = "Headphones & Audio", DisplayOrder = 3 },
                 new Category { Id = 4, Name = "Smart Gadgets", DisplayOrder = 4 }
            );
        }
    }
}
