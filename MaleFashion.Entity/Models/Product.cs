using MaleFashion.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Entity.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Sold { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime AddedDate { get; set; }
        public BrandsModel BrandsModel { get; set; }
        public List<Discount> Discounts { get; set; }        
        public List<ProductSubCategory> ProductSubCategories { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<ProductMainCategory> ProductMainCategories { get; set; }
        public List<ProductPhoto> ProductPhotos { get; set; }
        public List<ProductReview> ProductReviews { get; set; }
        public List<ProductOptionValue> ProductOptionValues { get; set; }

    }
}
