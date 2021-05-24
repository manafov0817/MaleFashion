using MaleFashion.Entity.Enums;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Entity.ViewComponentModel
{
    public class NewArrival
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int BestSellerId { get; set; }
        public BestSeller BestSeller { get; set; }
        public BestSellerTypeEnum BestSellerEnum { get; } = BestSellerTypeEnum.NewArrival;
    }
}

