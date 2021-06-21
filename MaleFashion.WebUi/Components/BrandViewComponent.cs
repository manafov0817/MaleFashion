using MaleFashion.Business.Abstract;
using MaleFashion.Entity.Models;
using MaleFashion.WebUi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaleFashion.WebUi.Components
{
    public class BrandViewComponent : ViewComponent
    {
        private readonly IBrandService _brandService;

        public BrandViewComponent(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IViewComponentResult Invoke()
        {           
            return View(ViewModel(_brandService.GetAll()));
        }

        public List<BrandsViewModel> ViewModel(List<Brand> brands)
        {
            List<BrandsViewModel> viewModels = new List<BrandsViewModel>();

            foreach (Brand brand in brands)
            {
                viewModels.Add(new BrandsViewModel()
                {
                    Id=brand.Id,
                    Name = brand.Name
                });
            }
            return viewModels;           
        }
    }
}
