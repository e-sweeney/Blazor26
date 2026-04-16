using Blazor26.Models.Models;
using Microsoft.EntityFrameworkCore;


namespace Blazor26.DataAccess.DataAccess
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Sales> Sales { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Books" },
                new Category { Id = 3, Name = "Clothing" }
            );

            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                new Product { ID = 1, Name = "Smartphone", Price = 699.99f, CategoryID = 1, description = "High-end smartphone", Image = "/Images/Products/smartphone.jpg" },
                new Product { ID = 2, Name = "Laptop", Price = 1299.99f, CategoryID = 1, description = "Powerful gaming laptop", Image = "/Images/Products/laptop.jpg" },
                new Product { ID = 3, Name = "Novel", Price = 19.99f, CategoryID = 2, description = "Interesting fiction novel", Image = "/Images/Products/novel.jpg" },
                new Product { ID = 4, Name = "Biography", Price = 24.99f, CategoryID = 2, description = "Famous person's biography", Image = "/Images/Products/biography.jpg" },
                new Product { ID = 5, Name = "T-Shirt", Price = 14.99f, CategoryID = 3, description = "Cotton t-shirt", Image = "/Images/Products/tshirt.jpg" },
                new Product { ID = 6, Name = "Jeans", Price = 49.99f, CategoryID = 3, description = "Denim jeans", Image = "/Images/Products/jeans.jpg" }
            );

            modelBuilder.Entity<Sales>().HasData(
                new Sales { Id = 1, ProductID = 1, MonthName = "January", SalesAmount = 10 },
                new Sales { Id = 2, ProductID = 2, MonthName = "February", SalesAmount = 5 },
                new Sales { Id = 3, ProductID = 3, MonthName = "March", SalesAmount = 9 },
                new Sales { Id = 4, ProductID = 4, MonthName = "April", SalesAmount = 5 },
                new Sales { Id = 5, ProductID = 5, MonthName = "May" , SalesAmount = 8 },
                new Sales { Id = 6, ProductID = 6, MonthName = "June", SalesAmount = 16 }



            );
        }
    }
}
