using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.WebUi.Models.ViewModels
{
    public class ShopViewModel
    {
        public string Name { get; set; }
        public decimal SellingPrice { get; set; }
        public Discount Discount { get; set; }
        public List<ProductPhoto> ProductPhotos { get; set; }
        public List<ProductReview> ProductReviews { get; set; }
        public List<ProductOptionValue> ProductOptionValues { get; set; }      
    }
}
