using MaleFashion.Business.Abstract;
using MaleFashion.Entity.Models;
using MaleFashion.WebUi.Enums;
using MaleFashion.WebUi.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace MaleFashion.WebUi.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ISubCategoryService _subCategoryService;
        private readonly ICategoryService _categoryService;
        private readonly IMainCategoryService _mainCategoryService;

        public CategoryViewComponent(ISubCategoryService subCategoryService,
                                     ICategoryService categoryService,
                                     IMainCategoryService mainCategoryService)
        {
            _subCategoryService = subCategoryService;
            _categoryService = categoryService;
            _mainCategoryService = mainCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            List<SubCategory> subCategories = _subCategoryService.GetAll();
            List<Category> categories = _categoryService.GetAll();
            List<MainCategory> mainCategories = _mainCategoryService.GetAll();

            List<ShopCategoryViewModel> viewModels = new List<ShopCategoryViewModel>();

            foreach (SubCategory subCategory in subCategories)
            {
                viewModels.Add(ViewModel(CategoryTypeEnum.SubCategory, subCategory.Id, subCategory.Name));
            }
            foreach (Category category in categories)
            {
                viewModels.Add(ViewModel(CategoryTypeEnum.Category, category.Id, category.Name));
            }
            foreach (MainCategory mainCategory in mainCategories)
            {
                viewModels.Add(ViewModel(CategoryTypeEnum.MainCategory, mainCategory.Id, mainCategory.Name));
            }

            return View(viewModels);
        }
        public ShopCategoryViewModel ViewModel(CategoryTypeEnum categoryType, int categoryId, string name)
        {
            return new ShopCategoryViewModel()
            {
                Name = name,
                CategoryId = categoryId,
                CategoryType = categoryType
            };
        }
    }
}
