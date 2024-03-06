using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(){}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){}
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Name",
                Price = new decimal(98.0),
                Description = "DescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescription",
                ImageUrl = "",
                CategoryName = "T-Shirt"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Name",
                Price = new decimal(98.0),
                Description = "DescriptionDescriptionDescriptionDescriptionDescriptionDescriptionDescription",
                ImageUrl = "",
                CategoryName = "T-Shirt"
            });

        }
    }
}
