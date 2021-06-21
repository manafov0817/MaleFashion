using MaleFashion.Entity.ViewComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Data.Abstract
{
    public interface IInstagramProfileRepository : IRepository<InstagramProfile>
    {
        InstagramProfile Get();
    }
}
