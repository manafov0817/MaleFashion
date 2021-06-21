using MaleFashion.Business.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.WebUi.Components
{
    public class BannerViewComponent : ViewComponent
    {
        private readonly IBannerService _bannerService;

        public BannerViewComponent(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        public IViewComponentResult Invoke()
        {
            List<Banner> banners = _bannerService.GetAll();
            return View(banners);
        }
    }
}
