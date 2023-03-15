using Microsoft.EntityFrameworkCore;

namespace IsleworksWebApp.Models
{
    public class CategoryContext : DbContext
    {
        public CategoryContext(DbContextOptions<CategoryContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        //seeds!
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Dummy"}
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, ProductName = "Dummy", ProductTime = 8, ProductBaseValue = 42}
                );
        }
    }
}
