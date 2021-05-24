using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Abstract
{
    public interface IProductOptionValueService : IGenericeService<ProductOptionValue>
    { 
        List<ProductOptionValue> GetAll (); 
    }
}
