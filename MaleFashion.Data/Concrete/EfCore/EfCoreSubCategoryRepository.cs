using Microsoft.EntityFrameworkCore;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCoreSubCategoryRepository : EfCoreGenericRepository<SubCategory, MaleFashionDbContext>, ISubCategoryRepository
    {
        public List<SubCategory> GetAllSubCategoriesWithCategoryAndMainCategory ()
        {
            using (var context = new MaleFashionDbContext( ))
            {
                List<SubCategory> subCategories = context.SubCategories
                                                         .Include(sc => sc.Category)
                                                         .ThenInclude(c => c.MainCategory)
                                                         .ToList( );
                return subCategories;
            }
        }

        public List<SubCategory> GetSubCategoriesByCategoryId ( int id )
        {
            using (var context = new MaleFashionDbContext( ))
            {
                List<SubCategory> subCategories = context.SubCategories.Where(sc => sc.CategoryId == id).ToList( );

                return subCategories;
            }
        }

     
        public SubCategory GetSubCategoryWithCategoryAndMainCategorybyId ( int id )
        {
            using (var context = new MaleFashionDbContext( ))
            {
                SubCategory subCategory = context.SubCategories
                                                    .Where(sc => sc.Id == id)
                                                    .Include(sc => sc.Category)
                                                    .ThenInclude(c => c.MainCategory)
                                                    .FirstOrDefault( );
                return subCategory;
            }
        }
    }
}
