using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using MaleFashion.Entity.ViewComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCoreInstagramProfileRepository : EfCoreGenericRepository<InstagramProfile, MaleFashionDbContext>, IInstagramProfileRepository
    {
        public InstagramProfile Get()
        {
            using (var context = new MaleFashionDbContext())
            {
                return context.InstagramProfile.FirstOrDefault();
            }
        }

    }
}
