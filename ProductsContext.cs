using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToodeteProgramm
{
    public class ProductsContext : DbContext
    {
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite
            ("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName ="Rice"},
                new Category { CategoryID = 2, CategoryName = "Soda" },
                new Category { CategoryID = 3, CategoryName = "Fruits" },
                new Category { CategoryID = 4, CategoryName = "Vegetables" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, CategoryID = 1, ProductName = "Brown rice"},
                new Product { ProductID = 2, CategoryID = 1, ProductName = "Basmati rice"},
                new Product { ProductID = 3, CategoryID = 1, ProductName = "Jasmine rice"},
                new Product { ProductID = 4, CategoryID = 1, ProductName = "Wild rice"},
                new Product { ProductID = 5, CategoryID = 1, ProductName = "Arborio rice"},
                new Product { ProductID = 6, CategoryID = 1, ProductName = "Black rice"},
                new Product { ProductID = 7, CategoryID = 1, ProductName = "Long grain rice"},
                new Product { ProductID = 8, CategoryID = 1, ProductName = "Red rice"},
                new Product { ProductID = 9, CategoryID = 1, ProductName = "White rice"},

                new Product { ProductID = 10, CategoryID = 2, ProductName = "Fanta"},
                new Product { ProductID = 11, CategoryID = 2, ProductName = "Pepsi"},
                new Product { ProductID = 12, CategoryID = 2, ProductName = "Coca cola"},
                new Product { ProductID = 13, CategoryID = 2, ProductName = "Sprite"},
                new Product { ProductID = 14, CategoryID = 2, ProductName = "Dr Pepper"},
                new Product { ProductID = 15, CategoryID = 2, ProductName = "7UP"},
                new Product { ProductID = 16, CategoryID = 2, ProductName = "Mountain Dew" },

                new Product { ProductID = 17, CategoryID = 3, ProductName = "Lime"},
                new Product { ProductID = 18, CategoryID = 3, ProductName = "Mango"},
                new Product { ProductID = 19, CategoryID = 3, ProductName = "Peach"},
                new Product { ProductID = 20, CategoryID = 3, ProductName = "Apple"},
                new Product { ProductID = 21, CategoryID = 3, ProductName = "Cherry"},
                new Product { ProductID = 22, CategoryID = 3, ProductName = "Orange"},
                new Product { ProductID = 23, CategoryID = 3, ProductName = "Banana"},
                new Product { ProductID = 24, CategoryID = 3, ProductName = "Watermelon"},
                new Product { ProductID = 25, CategoryID = 3, ProductName = "Coconut"},

                new Product { ProductID = 26, CategoryID = 4, ProductName = "Cabbage"},
                new Product { ProductID = 27, CategoryID = 4, ProductName = "Onion"},
                new Product { ProductID = 28, CategoryID = 4, ProductName = "Tomato"},
                new Product { ProductID = 29, CategoryID = 4, ProductName = "Potato"},
                new Product { ProductID = 30, CategoryID = 4, ProductName = "Carrot"},
                new Product { ProductID = 31, CategoryID = 4, ProductName = "Corn"},
                new Product { ProductID = 32, CategoryID = 4, ProductName = "Garlic"},
                new Product { ProductID = 33, CategoryID = 4, ProductName = "Cauliflower"});
        }
    }
}
