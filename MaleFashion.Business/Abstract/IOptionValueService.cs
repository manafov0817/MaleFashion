using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Abstract
{
    public interface IOptionValueService : IGenericService<OptionValue>
    {
        List<OptionValue> GetAllWithOptions ();
        List<OptionValue> GetAllColors ();
        List<OptionValue> GetOptionValuesByOptionId ( int id );
    }
}
