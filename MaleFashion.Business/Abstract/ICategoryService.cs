﻿using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Abstract
{
    public interface ICategoryService : IGenericeService<Category>
    { 
        List<Category> GetAll (); 
        List<Category> GetAllCategoriesWithMainCategory ();
        List<Category> GetCategoriesByMainCategoryId ( int id );
        Category GetCategoryWithMainCategoryById ( int id );
        List<Category> GetAllWithEverything ();
    }
}
