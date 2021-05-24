﻿using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category> {
        List<Category> GetAllCategoriesWithMainCategory ();
        List<Category> GetCategoriesByMainCategoryId ( int id);
        Category GetCategoryWithMainCategoryById ( int id );
        List<Category> GetAllWithEverything ();
    }
}
