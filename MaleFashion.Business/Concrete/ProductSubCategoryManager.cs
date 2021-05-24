using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class ProductSubCategoryManager : IProductSubCategoryService
    {
        private IProductSubCategoryRepository _productSubCategory;
        public ProductSubCategoryManager ( IProductSubCategoryRepository productSubCategoryy )
        { 
            _productSubCategory = productSubCategoryy;
        }

        public void Create ( ProductSubCategory entity )
        {
            _productSubCategory.Create(entity);
        }

        public void Delete ( ProductSubCategory entity )
        {
            _productSubCategory.Delete(entity);
        }

        public List<ProductSubCategory> GetAll ()
        {
            return _productSubCategory.GetAll();
        }

        public ProductSubCategory GetById ( int id )
        {
            return _productSubCategory.GetById(id);
        }

        public void Update ( ProductSubCategory entity )
        {
            _productSubCategory.Update(entity);
        }
    }
}
