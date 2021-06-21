using MaleFashion.Entity.Models;
using MaleFashion.Entity.ViewComponentModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
   public class MaleFashionDbContext : DbContext
    {
        public MaleFashionDbContext() { }
        public MaleFashionDbContext(DbContextOptions<MaleFashionDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandsModel> BrandsModels { get; set; }
        //public DbSet<Cart> Carts { get; set; }
        //public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<OptionValue> OptionValues { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Review> Reviews { get; set; }
        //public DbSet<ProductRelate> ProductRelates { get; set; }
        public DbSet<ProductOptionValue> ProductOptionValues { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductMainCategory> ProductMainCategories { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Hero> Heros { get; set; }
        public List<BestSeller> BestSellers { get; set; }
        public DbSet<HotSale> HotSales { get; set; }
        public DbSet<NewArrival> NewArrivals { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<DealOfTheWeek> DealOfTheWeeks { get; set; }
        public DbSet<InstagramProfile> InstagramProfile { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS; Initial Catalog = MaleFashionDbContext; Integrated Security = SSPI");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductOptionValue>().HasKey(c => new { c.ProductId, c.OptionValueId });


            modelBuilder.Entity<ProductPhoto>().HasKey(c => new { c.ProductId, c.PhotoId });


            modelBuilder.Entity<ProductReview>().HasKey(c => new { c.ProductId, c.ReviewId });


            modelBuilder.Entity<ProductSubCategory>().HasKey(c => new { c.ProductId, c.SubCategoryId });


            modelBuilder.Entity<ProductCategory>().HasKey(c => new { c.ProductId, c.CategoryId });


            modelBuilder.Entity<ProductMainCategory>().HasKey(c => new { c.ProductId, c.MainCategoryId });


            modelBuilder.Entity<BestSeller>().HasOne(bs => bs.Product).WithMany().OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<ProductRelate>().HasKey(c => new { c.ProductId, c.RelateId });

        }
    }
}
