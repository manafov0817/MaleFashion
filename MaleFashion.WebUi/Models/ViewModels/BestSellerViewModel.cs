using MaleFashion.Entity.Enums;
using MaleFashion.Entity.ViewComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.WebUi.Models.ViewModels
{
    public class BestSellerViewModel : BestSeller
    {
        public BestSellerTypeEnum BestSellerEnum { get; set; }
    }
}
