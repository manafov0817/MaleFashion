using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Abstract
{
    public interface IContactService : IGenericeService<Contact>
    { 
        List<Contact> GetAll (); 
    }
}
