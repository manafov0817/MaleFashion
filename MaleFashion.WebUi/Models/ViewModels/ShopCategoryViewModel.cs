using MaleFashion.WebUi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.WebUi.Models.ViewModels
{
    public class ShopCategoryViewModel
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public CategoryTypeEnum CategoryType { get; set; }
    }
}
