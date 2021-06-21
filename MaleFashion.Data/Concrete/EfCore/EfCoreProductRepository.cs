using Microsoft.EntityFrameworkCore;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, MaleFashionDbContext>, IProductRepository
    {
        public List<Product> GetAllDiscountedProducts()
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.Products.ToList();
                //.Where(p => p.DiscountWithMoney > 0 || p.DiscountWithPercent > 0)
                //.Include(p => p.ProductPhotos)
                //    .ThenInclude(pp => pp.Photo)

            }
        }

        public List<Product> GetAllForShopFilter()
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.Products
                        .Include(p => p.BrandsModel)
                        .ToList();
            }
        }

        public List<Product> GetAllProductsForShop()
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.Products
                        .Include(p => p.ProductPhotos)
                            .ThenInclude(pp => pp.Photo)
                        .ToList();
            }
        }

        public Product GetByIdForShopPage(int id)
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.Products
                        .Include(p => p.ProductPhotos)
                            .ThenInclude(pp => pp.Photo)
                        .Include(p => p.ProductReviews)
                        .Include(p=>p.ProductOptionValues)
                        .Where(p=>p.Id==id)
                        .FirstOrDefault();
            }
        }

        public Product GetProductForDetailById(int id)
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.Products
                        .Where(p => p.Id == id)
                        .Include(p => p.ProductPhotos)
                            .ThenInclude(pp => pp.Photo)
                        .Include(p => p.ProductSubCategories)
                            .ThenInclude(ps => ps.SubCategory)
                                .ThenInclude(s => s.Category)
                                    .ThenInclude(c => c.MainCategory)
                        .Include(p => p.ProductCategories)
                            .ThenInclude(pc => pc.Category)
                                .ThenInclude(c => c.MainCategory)
                        .Include(p => p.ProductMainCategories)
                            .ThenInclude(pmc => pmc.MainCategory)
                        .Include(p => p.ProductOptionValues)
                            .ThenInclude(pov => pov.OptionValue)
                                .ThenInclude(ov => ov.Option)
                        .FirstOrDefault();
            }
        }

        public List<Product> GetProductsByBrandId(int id)
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.Products

                                .Include(p => p.ProductPhotos)
                                    .ThenInclude(pp => pp.Photo)
                                .Include(p => p.ProductCategories)
                                .Include(p => p.ProductMainCategories)
                                .Include(p => p.ProductSubCategories)
                                .Where(p => p.BrandsModel.BrandId == id)
                                .ToList();
            }
        }

        public List<Product> GetProductsByCategoryId(int id)
        {
            using (var context = new MaleFashionDbContext())
            {
                List<ProductCategory> productCategories = context.ProductCategories
                                                                 .Where(pc => pc.CategoryId == id)
                                                                 .ToList();

                List<Product> products = new List<Product>();

                foreach (var productCategory in productCategories)
                {
                    List<Product> mainCategoryProducts = context.Products.Where(p => p.Id == productCategory.ProductId)
                                                                         .Include(p => p.BrandsModel)
                                                                         .ToList();
                    products.AddRange(mainCategoryProducts);
                }

                return products;
            }
        }

        public List<Product> GetProductsByMainCategoryId(int id)
        {
            using (var context = new MaleFashionDbContext())
            {
                List<ProductMainCategory> productMainCategories = context.ProductMainCategories
                                                                 .Where(pc => pc.MainCategoryId == id)
                                                                 .ToList();

                List<Product> products = new List<Product>();

                foreach (var productMainCategory in productMainCategories)
                {
                    List<Product> mainCategoryProducts = context.Products.Where(p => p.Id == productMainCategory.ProductId)
                                                                         .Include(p => p.BrandsModel)
                                                                         .ToList();
                    products.AddRange(mainCategoryProducts);
                }

                return products;
            }
        }

        public List<Product> GetProductsByName(string name)
        {
            using (var context = new MaleFashionDbContext())
            {
                List<Product> products = context.Products
                                                    .Where(p => p.Name.ToLower().Contains(name.ToLower()))
                                                    .Include(p => p.ProductPhotos)
                                                        .ThenInclude(pp => pp.Photo)
                                                    .Include(p => p.ProductCategories)
                                                    .Include(p => p.ProductMainCategories)
                                                    .Include(p => p.ProductSubCategories)
                                                    .ToList();
                return products;
            }
        }

        public List<Product> GetProductsByOptionValueId(int id)
        {
            using (var context = new MaleFashionDbContext())
            {
                List<ProductOptionValue> productOptionValues = context.ProductOptionValues
                                                                                 .ToList();
                List<Product> products = new List<Product>();

                List<Product> contextProducts = context.Products
                                                            .Include(p => p.ProductPhotos)
                                                                .ThenInclude(pp => pp.Photo)
                                                            .Include(p => p.ProductCategories)
                                                            .Include(p => p.ProductMainCategories)
                                                            .Include(p => p.ProductSubCategories)
                                                            .ToList();

                foreach (ProductOptionValue productOptionValue in productOptionValues)
                {
                    if (productOptionValue.OptionValueId == id)
                    {
                        Product product = context.Products
                                                .Where(p => p.Id == productOptionValue.ProductId)
                                                .Include(p => p.ProductPhotos)
                                                    .ThenInclude(pp => pp.Photo)
                                                .Include(p => p.ProductCategories)
                                                .Include(p => p.ProductMainCategories)
                                                .Include(p => p.ProductSubCategories)
                                                .FirstOrDefault();
                        if (!products.Contains(product))
                        {
                            products.Add(product);
                        }
                    }
                }
                return products;
            }
        }

        public List<Product> GetProductsByPrice(decimal minPrice, decimal maxPrice)
        {
            using (var context = new MaleFashionDbContext())
            {
                List<Product> products = context.Products
                                                        .Where(p => p.SellingPrice > minPrice && p.SellingPrice < maxPrice)
                                                        .ToList();
                return products;
            }
        }

        public List<Product> GetProductsBySubCategoryId(int id)
        {
            using (var context = new MaleFashionDbContext())
            {
                List<ProductSubCategory> productSubCategories = context.ProductSubCategories
                                                                 .Where(pc => pc.SubCategoryId == id)
                                                                 .ToList();

                List<Product> products = new List<Product>();

                foreach (var productSubCategory in productSubCategories)
                {
                    List<Product> subCategoryProducts = context.Products.Where(p => p.Id == productSubCategory.ProductId)
                                                                        .Include(p => p.BrandsModel)
                                                                        .ToList();
                    products.AddRange(subCategoryProducts);
                }

                return products;
            }
        }

        public List<Product> GetProductWithCategoryTypes()
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.Products
                        .Include(p => p.ProductPhotos)
                            .ThenInclude(pp => pp.Photo)
                        .Include(p => p.ProductSubCategories)
                            .ThenInclude(ps => ps.SubCategory)
                                .ThenInclude(s => s.Category)
                                    .ThenInclude(c => c.MainCategory)
                        .Include(p => p.ProductCategories)
                            .ThenInclude(pc => pc.Category)
                                .ThenInclude(c => c.MainCategory)
                        .Include(p => p.ProductMainCategories)
                            .ThenInclude(pmc => pmc.MainCategory)
                        .ToList();
            }
        }

        public Product GetProductWithEverythingById(int id)
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.Products
                        .Where(p => p.Id == id)
                        .Include(p => p.ProductPhotos)
                            .ThenInclude(pp => pp.Photo)
                        .Include(p => p.ProductSubCategories)
                            .ThenInclude(ps => ps.SubCategory)
                                .ThenInclude(s => s.Category)
                                    .ThenInclude(c => c.MainCategory)
                        .Include(p => p.ProductCategories)
                            .ThenInclude(pc => pc.Category)
                                .ThenInclude(c => c.MainCategory)
                        .Include(p => p.ProductMainCategories)
                            .ThenInclude(pmc => pmc.MainCategory)
                        .Include(p => p.ProductOptionValues)
                            .ThenInclude(pov => pov.OptionValue)
                                .ThenInclude(ov => ov.Option)
                        .FirstOrDefault();
            }
        }

        public List<Product> GetTopProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetWithRelateById(int id)
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.Products

                        .FirstOrDefault();
            }
        }
    }
}
