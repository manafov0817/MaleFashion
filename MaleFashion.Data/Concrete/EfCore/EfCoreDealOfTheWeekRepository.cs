using MaleFashion.Data.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCoreDealOfTheWeekRepository : EfCoreGenericRepository<DealOfTheWeek, MaleFashionDbContext>, IDealOfTheWeekRepository
    {
        public DealOfTheWeek Get()
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.DealOfTheWeeks.Include(hs => hs.Product)
                                                 .ThenInclude(p => p.ProductPhotos)
                                                    .ThenInclude(pp => pp.Photo)
                                             .Include(hs => hs.Product)
                                                 .ThenInclude(p => p.Discount)
                                             .FirstOrDefault();
            }
        }
    }
}
