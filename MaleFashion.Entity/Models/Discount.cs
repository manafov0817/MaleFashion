using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MaleFashion.Entity.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public decimal? DiscountWithPercent { get; set; }
        public decimal? DiscountWithNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
