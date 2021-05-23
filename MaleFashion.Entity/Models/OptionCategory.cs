using MaleFashion.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Entity.Models
{
    public class OptionCategory
    {
        public int Id { get; set; }
        public CategoryTypeEnum CategoryType { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
