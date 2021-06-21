using MaleFashion.Data.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCoreNewArrivalRepository : EfCoreGenericRepository<NewArrival, MaleFashionDbContext>, INewArrivalRepository
    {
        public new List<NewArrival> GetAll()
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.NewArrivals.Include(hs => hs.Product)
                                                 .ThenInclude(p => p.ProductPhotos)
                                                    .ThenInclude(pp => pp.Photo)
                                                 .ToList();
            }
        }
    }
}
