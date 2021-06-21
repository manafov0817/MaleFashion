using MaleFashion.Entity.ViewComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Abstract
{
    public interface IDealOfTheWeekService : IGenericService<DealOfTheWeek>
    {
        public DealOfTheWeek Get();
    }
}
