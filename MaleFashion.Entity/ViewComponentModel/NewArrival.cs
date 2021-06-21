using MaleFashion.Entity.Enums;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Entity.ViewComponentModel
{
    public class NewArrival : BestSeller
    {
        public BestSellerTypeEnum BestSellerEnum { get; } = BestSellerTypeEnum.NewArrival;
    }
}

