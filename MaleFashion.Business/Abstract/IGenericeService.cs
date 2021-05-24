using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Abstract
{
   public interface IGenericeService<T>
    {
        T GetById ( int id );
        List<T> GetAll();
        void Create ( T entity );
        void Update ( T entity );
        void Delete ( T entity );
    }
}
