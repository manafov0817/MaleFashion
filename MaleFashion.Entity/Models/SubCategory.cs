using MaleFashion.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaleFashion.Entity.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public StatusEnum Status { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category{ get; set; }
        public List<ProductSubCategory> ProductSubCategories { get; set; }

    }
}
