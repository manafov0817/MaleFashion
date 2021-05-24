using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Abstract
{
    public interface IProductCategoryService : IGenericeService<ProductCategory>
    { 
        List<ProductCategory> GetAll (); 
    }
}
