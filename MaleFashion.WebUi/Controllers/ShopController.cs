using MaleFashion.Data.Abstract;
using MaleFashion.WebUi.Enums;
using MaleFashion.Entity.Models;
using MaleFashion.WebUi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaleFashion.WebUi.Models.ViewModels;

namespace MaleFashion.WebUi.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ISubCategoryRepository _subCategoryRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMainCategoryRepository _mainCategoryRepository;

        public ShopController(IProductRepository productRepository,
                              ISubCategoryRepository subCategoryRepository,
                              ICategoryRepository categoryRepository,
                              IMainCategoryRepository mainCategoryRepository)
        {
            _productRepository = productRepository;
            _subCategoryRepository = subCategoryRepository;
            _categoryRepository = categoryRepository;
            _mainCategoryRepository = mainCategoryRepository;
        }

        public IActionResult Index(string name, int pageSize = 16, int pageNumber = 1)
        {

            List<Product> filteredProducts = GetDefaultFilteredProducts().ToList();

            if (name != null)
            {
                filteredProducts = filteredProducts.Where(fp => fp.Name.ToLower().Contains(name.ToLower())).ToList();
            }

            int productCount = filteredProducts.Count;
            TempData["ProductCount"] = productCount;
            TempData["PageCount"] = productCount % pageSize == 0 ? productCount / pageSize : productCount / pageSize + 1;
            TempData["PageNumber"] = pageNumber;
            TempData["PageSize"] = pageSize;

            List<Product> products = new List<Product>();

            foreach (Product product in filteredProducts
                                            .Skip((pageNumber - 1) * pageSize)
                                            .Take(pageSize)
                                            .ToList())
                products.Add(_productRepository.GetByIdForShopPage(product.Id));


            if (ShopOrder.OrderPrice == OrderPriceEnum.Ascending)
                products = products.OrderBy(p => p.SellingPrice).ToList();
            else if (ShopOrder.OrderPrice == OrderPriceEnum.Descending)
                products = products.OrderByDescending(p => p.SellingPrice).ToList();


            if (ShopOrder.OrderName == OrderNameEnum.Ascending)
                products = products.OrderBy(p => p.Name).ToList();
            else if (ShopOrder.OrderName == OrderNameEnum.Descending)
                products = products.OrderByDescending(p => p.Name).ToList();

            return View(ViewModel(products));
        }


        public List<Product> GetDefaultFilteredProducts()
        {
            List<Product> filteredProducts = _productRepository.GetAllForShopFilter();

            if (ShopFilter.CategoryId != 0)
            {
                switch (ShopFilter.CategoryType)
                {
                    case CategoryTypeEnum.SubCategory:
                        filteredProducts = _productRepository.GetProductsBySubCategoryId(ShopFilter.CategoryId).ToList();
                        break;
                    case CategoryTypeEnum.Category:
                        filteredProducts = _productRepository.GetProductsByCategoryId(ShopFilter.CategoryId).ToList();
                        break;
                    case CategoryTypeEnum.MainCategory:
                        filteredProducts = _productRepository.GetProductsByMainCategoryId(ShopFilter.CategoryId).ToList();
                        break;
                    default:
                        break;
                }
            }

            if (ShopFilter.BrandIds != null && ShopFilter.BrandIds.Count != 0)
            {

                List<Product> filteredProductsBrand = new List<Product>();

                foreach (int brandId in ShopFilter.BrandIds)
                {
                    filteredProductsBrand.AddRange(filteredProducts
                                            .Where(p => p.BrandsModel != null && p.BrandsModel.BrandId == brandId)
                                            .ToList());
                }

                filteredProducts = filteredProductsBrand.ToList();

            }



            if (ShopFilter.MinPrice != 0 && ShopFilter.MaxPrice == 0)
                filteredProducts = filteredProducts
                                        .Where(p => p.SellingPrice > ShopFilter.MinPrice)
                                        .ToList();            

            else if (ShopFilter.MinPrice == 0 && ShopFilter.MaxPrice != 0)
                filteredProducts = filteredProducts
                                        .Where(p => p.SellingPrice < ShopFilter.MaxPrice)
                                        .ToList();

            else if (ShopFilter.MinPrice != 0 && ShopFilter.MaxPrice != 0 && ShopFilter.MinPrice < ShopFilter.MaxPrice)
                filteredProducts = filteredProducts
                                        .Where(p => p.SellingPrice > ShopFilter.MinPrice && p.SellingPrice < ShopFilter.MaxPrice)
                                        .ToList();

            return filteredProducts;
        }


        public IActionResult ChangeCategoryFilter(int id, CategoryTypeEnum categoryTypeEnum)
        {
            ShopFilter.CategoryId = id;
            ShopFilter.CategoryType = categoryTypeEnum;


            switch (categoryTypeEnum)
            {
                case CategoryTypeEnum.SubCategory:
                    ShopFilter.CategoryName = _subCategoryRepository.GetById(id).Name;
                    break;
                case CategoryTypeEnum.Category:
                    ShopFilter.CategoryName = _categoryRepository.GetById(id).Name;
                    break;
                case CategoryTypeEnum.MainCategory:
                    ShopFilter.CategoryName = _mainCategoryRepository.GetById(id).Name;
                    break;
                default:
                    break;
            }

            return RedirectToAction("Index", "Shop");
        }

        public void ResetCategoryFilter()
        {
            ShopFilter.CategoryId = 0;
            ShopFilter.CategoryType = null;
        }
        public IActionResult ResetCategoryFilterForIndex()
        {
            ShopFilter.CategoryId = 0;
            ShopFilter.CategoryType = null;
            return RedirectToAction("Index");
        }

        public void ChangeBrandFilter(List<int> ids)
        {
            ShopFilter.BrandIds = new List<int>(); ;

            foreach (int id in ids)
            {
                ShopFilter.BrandIds.Add(id);
            }
        }
        public void ResetBrandFilter()
        {
            ShopFilter.BrandIds = null;
        }


        public void ChangePriceFilter(decimal minPrice, decimal maxPrice)
        {
            ShopFilter.MinPrice = minPrice;
            ShopFilter.MaxPrice = maxPrice;
        }
        public void ResetPriceFilter()
        {
            ShopFilter.MinPrice = 0;
            ShopFilter.MaxPrice = 0;
        }


        [HttpPost]
        public IActionResult Filter(decimal minPrice, decimal maxPrice, List<int> brandIds)
        {

            ChangeBrandFilter(brandIds);
            ChangePriceFilter(minPrice, maxPrice);

            return RedirectToAction("Index", "Shop");
        }

        public IActionResult OrderByName(OrderNameEnum orderName)
        {
            ShopOrder.OrderName = orderName;
            ShopOrder.OrderPrice = null;
            return RedirectToAction("Index", "Shop");
        }

        public IActionResult OrderByPrice(OrderPriceEnum orderPrice)
        {
            ShopOrder.OrderPrice = orderPrice;
            ShopOrder.OrderName = null;

            return RedirectToAction("Index", "Shop");
        }


        public IActionResult ResetFilter()
        {
            ResetCategoryFilter();
            ResetBrandFilter();
            ResetPriceFilter();
            return RedirectToAction("Index", "Shop");

        }





        public List<ShopViewModel> ViewModel(List<Product> products)
        {
            List<ShopViewModel> shopViewModels = new List<ShopViewModel>();

            foreach (Product product in products)
            {
                shopViewModels.Add(new ShopViewModel()
                {
                    Name = product.Name,
                    SellingPrice = product.SellingPrice,
                    Discount = product.Discount,
                    ProductOptionValues = product.ProductOptionValues,
                    ProductPhotos = product.ProductPhotos,
                    ProductReviews = product.ProductReviews
                });
            }
            return shopViewModels;
        }
    }
}
