using Microsoft.EntityFrameworkCore;
using Data.Entities;
using DataAccess.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Data
{
    public class ShopDbContext : IdentityDbContext<User>
    {
        public ShopDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Electronics" },
                new Category() { Id = 2, Name = "Sport" },
                new Category() { Id = 3, Name = "Fashion" },
                new Category() { Id = 4, Name = "Home & Garden" },
                new Category() { Id = 5, Name = "Transport" },
                new Category() { Id = 6, Name = "Toys & Hobbies" },
                new Category() { Id = 7, Name = "Musical Instruments" },
                new Category() { Id = 8, Name = "Art" },
                new Category() { Id = 9, Name = "Books" }
            });

            modelBuilder.Entity<Product>().HasData(new[]
            {
            new Product() { Id = 1, Title = "iPhone X",City="Rivne",Condition="New", CategoryId = 1, Price = 650,Contact="0312921399", ImageUrl="https://www.freeiconspng.com/thumbs/iphone-x-pictures/new-iphone-x-photo-18.png" , Description="iPhone X laalalala" },
            new Product() { Id = 2, Title = "PowerBall",City="Rivne",Condition="New", CategoryId = 6, Price = 45,Contact="04122411399",ImageUrl="https://content.rozetka.com.ua/goods/images/original/218131771.jpg", Description="PowerBall laalalala" },
            new Product() { Id = 3, Title = "Nike T-Shirt",City="Rivne",Condition="New", CategoryId = 3, Price = 189,Contact="0675586399",ImageUrl="https://www.seekpng.com/png/full/316-3168852_nike-air-logo-t-shirt-nike-t-shirt.png", Description="Nike T-Shirt laalalala" },
            new Product() { Id = 4, Title = "Samsung S23",City="Rivne",Condition="Used", CategoryId = 1, Price = 1200,Contact="097642399",ImageUrl="https://cdn.samsungshop.com.ua/products/7490/cover/90471/Rectangle-140.png", Description="Samsung S23 laalalala" },
            new Product() { Id = 5, Title = "A Song of Ice and Fire" ,City="Rivne", Condition="Used", CategoryId = 9, Price = 20,Contact="097442399",ImageUrl="https://2books.su/assets/img/covers/a-dance-with-dragons-george-r-r-martin.jpg", Description="Book laalalala" }

            });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
