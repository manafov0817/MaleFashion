using MaleFashion.Business.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.WebUi.Components
{
    public class DealsOfTheWeekViewComponent : ViewComponent
    {
        private readonly IDealOfTheWeekService _dealOfTheWeekService;

        public DealsOfTheWeekViewComponent(IDealOfTheWeekService dealOfTheWeekService)
        {
            _dealOfTheWeekService = dealOfTheWeekService;
        }

        public IViewComponentResult Invoke()
        {
            DealOfTheWeek dealOfTheWeek = _dealOfTheWeekService.Get();
            return View(dealOfTheWeek);
        }
    }
}
