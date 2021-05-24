using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Abstract
{
    public interface IOptionService : IGenericeService<Option>
    { 
        List<Option> GetAll (); 
        Option GetByName ( string value );
    }
}
