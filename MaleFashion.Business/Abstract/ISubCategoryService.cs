using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Abstract
{
    public interface ISubCategoryService : IGenericService<SubCategory> 
    { 
         List<SubCategory> GetAllSubCategoriesWithCategoryAndMainCategory ();
        List<SubCategory> GetSubCategoriesByCategoryId ( int id );
        SubCategory GetSubCategoryWithCategoryAndMainCategorybyId ( int id );
    }
}
