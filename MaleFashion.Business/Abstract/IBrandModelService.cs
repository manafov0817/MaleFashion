using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Abstract
{
    public interface IBrandsModelService : IGenericeService<BrandsModel>
    {      
         List<BrandsModel> GetBrandsModelsWithBrands ();
        List<BrandsModel> GetModelsByBrandId ( int id );
    }
}
