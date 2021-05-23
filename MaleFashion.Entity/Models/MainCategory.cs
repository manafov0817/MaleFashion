using MaleFashion.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Entity.Models
{
    public class MainCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public StatusEnum Status { get; set; }
        public List<ProductMainCategory> ProductMainCategories { get; set; }
    }
}
