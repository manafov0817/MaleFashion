using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Entity.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductPhoto> ProductPhotos { get; set; }

    }
}
