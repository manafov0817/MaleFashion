using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Data.Abstract
{
   public interface IMainCategoryRepository : IRepository<MainCategory> {
        List<MainCategory> GetAllWithEverything ();
    }
}
