using Microsoft.EntityFrameworkCore;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCoreMainCategoryRepository : EfCoreGenericRepository<MainCategory, MaleFashionDbContext>, IMainCategoryRepository
    {
        public List<MainCategory> GetAllWithEverything ()
        {
            using (var context = new MaleFashionDbContext( ))
            {
                return context.MainCategories 
                                .ToList( );                                   
            }
        }
    }
}
