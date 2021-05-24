using Microsoft.EntityFrameworkCore;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, MaleFashionDbContext>, ICategoryRepository
    {
        public List<Category> GetAllCategoriesWithMainCategory ()
        {
            using (var context = new MaleFashionDbContext( ))
            {
                List<Category> categories = context.Categories.Include(c => c.MainCategory).ToList( );
                return categories;
            }
        }

        public List<Category> GetAllWithEverything ()
        {
            using (var context = new MaleFashionDbContext( ))
            {
                return context.Categories
                                .Include(c => c.MainCategory)
                                 
                                .ToList( );
            }
        }

        public List<Category> GetCategoriesByMainCategoryId ( int id )
        {
            using (var context = new MaleFashionDbContext( ))
            {
                List<Category> categories = context.Categories.Where(c => c.MainCategoryId == id).ToList( );
                return categories;
            }
        }

        public Category GetCategoryWithMainCategoryById ( int id )
        {
            using (var context = new MaleFashionDbContext( ))
            {
                return context.Categories
                                    .Where(c => c.Id == id)
                                    .Include(c => c.MainCategory)
                                    .FirstOrDefault( );
            }
        }
    }
}
