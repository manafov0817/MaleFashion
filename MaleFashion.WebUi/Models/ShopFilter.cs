using MaleFashion.WebUi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.WebUi.Models
{
    public static class ShopFilter
    {
        public static CategoryTypeEnum? CategoryType { get; set; } 
        public static int CategoryId { get; set; }
        public static string  CategoryName { get; set; }
        public static List<int> BrandIds { get; set; }
        public static decimal MinPrice { get; set; } 
        public static decimal MaxPrice { get; set; } 
    }
}
