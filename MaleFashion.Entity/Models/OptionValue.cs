using MaleFashion.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaleFashion.Entity.Models
{
    public class OptionValue
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public StatusEnum Status { get; set; }
        [ForeignKey("Category")]
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public List<ProductOptionValue> ProductOptionValues { get; set; }

    }
}
