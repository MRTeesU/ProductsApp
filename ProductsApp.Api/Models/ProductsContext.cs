using Microsoft.EntityFrameworkCore;
using ProductsApp.Api.Models;
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
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Products;");
        //options.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=Products;");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //allows Order class to not have primary key of its own
            base.OnModelCreating(builder);
            builder.Entity<Order>()
                .HasKey(a => new { a.ProductId, a.UserId });

            builder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Example Product 1", Description = "Example ",Price = 1 ,InStock = true },
                new Product { ProductId = 2, Name = "Example Product 2", Description = "Example ", Price = 2, InStock = true },
                new Product { ProductId = 3, Name = "Example Product 3", Description = "Example ", Price = 3, InStock = true },
                new Product { ProductId = 4, Name = "Example Product 4", Description = "Example ", Price = 4, InStock = true },
                new Product { ProductId = 5, Name = "Example Product 5", Description = "Example ", Price = 5, InStock = true },
                new Product { ProductId = 6, Name = "Example Product 6", Description = "Example ", Price = 6, InStock = true }
                );
            builder.Entity<User>().HasData(
                new User { UserId = 1, Name = "Person 1", Role = "Unregistered Customer"},
                new User { UserId = 2, Name = "Person 2", Role = "Registered Customer" },
                new User { UserId = 3, Name = "Person 3", Role = "Staff" },
                new User { UserId = 4, Name = "Person 4", Role = "Management" }
                );
            builder.Entity<Order>().HasData(
                new Order { UserId = 1, ProductId = 1 },
                new Order { UserId = 2, ProductId = 2 },
                new Order { UserId = 3, ProductId = 3 },
                new Order { UserId = 4, ProductId = 4 }
                );
        }
    }
}
