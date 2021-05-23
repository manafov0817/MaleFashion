using MaleFashion.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaleFashion.Entity.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public StatusEnum Status { get; set; }
        [ForeignKey("MainCategory")]
        public int MainCategoryId { get; set; }
        public MainCategory MainCategory { get; set; }
        public List<ProductCategory> ProductSubCategories { get; set; }

    }
}
