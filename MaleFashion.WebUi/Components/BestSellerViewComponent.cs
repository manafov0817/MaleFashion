using MaleFashion.Business.Abstract;
using MaleFashion.Entity.Enums;
using MaleFashion.Entity.ViewComponentModel;
using MaleFashion.WebUi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.WebUi.Components
{
    public class BestSellerViewComponent : ViewComponent
    {
        private readonly IHotSaleService _hotSaleService;
        private readonly INewArrivalService _newArrivalService;
        public BestSellerViewComponent(IHotSaleService hotSaleService,
                                       INewArrivalService newArrivalService)
        {
            _hotSaleService = hotSaleService;
            _newArrivalService = newArrivalService;
        }
        public IViewComponentResult Invoke()
        {

            List<HotSale> hotSales = _hotSaleService.GetAll();
            List<NewArrival> newArrivals = _newArrivalService.GetAll();
            List<BestSellerViewModel> bestSellers = new List<BestSellerViewModel>();

            int k = 1, hs = 0, na = 0;

            while (bestSellers.Count != hotSales.Count + newArrivals.Count)
            {
                if (k == 1)
                {
                    bestSellers.Add(new BestSellerViewModel()
                    {
                        Product = hotSales[hs].Product,
                        BestSellerEnum = BestSellerTypeEnum.HotSale
                    });
                    hs++;
                }
                else if (k == -1 && na < newArrivals.Count)
                {
                    bestSellers.Add(new BestSellerViewModel()
                    {
                        Product = newArrivals[na].Product,
                        BestSellerEnum = BestSellerTypeEnum.NewArrival
                    });
                    na++;
                }
                k *= -1;
            }

            return View(bestSellers);
        }
    }
}
