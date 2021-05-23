using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Entity.Models
{
    public class ProductPhoto
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}