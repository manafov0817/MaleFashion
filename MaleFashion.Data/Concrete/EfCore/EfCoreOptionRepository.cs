using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCoreOptionRepository : EfCoreGenericRepository<Option, MaleFashionDbContext>, IOptionRepository
    {
        public Option GetByName ( string value )
        {
            using var context = new MaleFashionDbContext();
            return context.Options
                               .Where(o => o.Name.ToLower() == value.ToLower())
                               .FirstOrDefault();
        }
    }
}
