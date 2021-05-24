using MaleFashion.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.WebUi.Components
{
    public class HeroViewComponent: ViewComponent
    {
        private readonly IHeroService _heroService;
        public HeroViewComponent(IHeroService heroService)
        {
            _heroService = heroService;
        }
        public IViewComponentResult Invoke()
        {

            return View(_heroService.GetAll());
        }
    }
}
