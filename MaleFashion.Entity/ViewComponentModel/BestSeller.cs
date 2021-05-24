using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Entity.ViewComponentModel
{
    public class BestSeller
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
