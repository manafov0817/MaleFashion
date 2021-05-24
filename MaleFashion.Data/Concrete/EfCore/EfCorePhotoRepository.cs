using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Data.Concrete.EfCore
{
    public class EfCorePhotoRepository : EfCoreGenericRepository<Photo, MaleFashionDbContext>, IPhotoRepository { }
}
