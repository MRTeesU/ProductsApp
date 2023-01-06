using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Models
{
    public class ProductsContext :DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<User> Users{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Server={localdb}\mssqllocaldb;Database=Products;");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Example Product 1", Description = "Example ",Price = 1 ,InStock = true },
                new Product { Id = 2, Name = "Example Product 2", Description = "Example ", Price = 2, InStock = true },
                new Product { Id = 3, Name = "Example Product 3", Description = "Example ", Price = 3, InStock = true },
                new Product { Id = 4, Name = "Example Product 4", Description = "Example ", Price = 4, InStock = true },
                new Product { Id = 5, Name = "Example Product 5", Description = "Example ", Price = 5, InStock = true },
                new Product { Id = 6, Name = "Example Product 6", Description = "Example ", Price = 6, InStock = true }
                );
            builder.Entity<User>().HasData(
                new User { Id = 1,Name = "Person 1",Role = "Unregistered Customer"},
                new User { Id = 2, Name = "Person 2", Role = "Registered Customer" },
                new User { Id = 3, Name = "Person 3", Role = "Staff" },
                new User { Id = 4, Name = "Person 4", Role = "Management" }
                );
            //put user and model seed data here after creating respective models.
        }
    }
}
