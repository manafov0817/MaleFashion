using MaleFashion.WebUi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.WebUi.Models
{
    public static class ShopOrder
    {
        public static OrderPriceEnum? OrderPrice { get; set; } = null;
        public static OrderNameEnum? OrderName { get; set; } = null;
    }
}
