using Microsoft.EntityFrameworkCore;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCoreBrandModelRepository : EfCoreGenericRepository<BrandsModel, MaleFashionDbContext>, IBrandModelRepository
    {
        public List<BrandsModel> GetBrandModelsWithBrands ()
        {
            using var context = new MaleFashionDbContext();
            return context.BrandsModels.Include(b => b.Brand).ToList();
        }

        public List<BrandsModel> GetModelsByBrandId ( int id )
        {
            using (var context = new MaleFashionDbContext( ))
            {
                return context.BrandsModels.Where(bm=>bm.BrandId==id).ToList( );
            }
        }
    }
}
