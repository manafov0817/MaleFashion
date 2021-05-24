using MaleFashion.Data.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCoreHeroRepository : EfCoreGenericRepository<Hero, MaleFashionDbContext>, IHeroRepository
    {
    }
}
