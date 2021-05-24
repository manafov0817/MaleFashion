using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Data.Abstract
{
    public interface IBrandModelRepository : IRepository<BrandsModel>
    {
        List<BrandsModel> GetBrandModelsWithBrands();
        List<BrandsModel> GetModelsByBrandId(int id);
    }
}
