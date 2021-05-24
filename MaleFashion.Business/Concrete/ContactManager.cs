using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private IContactRepository _contactRepository;
        public ContactManager ( IContactRepository contactRepository )
        {
            _contactRepository = contactRepository;
        }
        public void Create ( Contact entity )
        {
            _contactRepository.Create(entity);
        }

        public void Delete ( Contact entity )
        {
            _contactRepository.Delete(entity);
        }

        public List<Contact> GetAll ()
        {
            return _contactRepository.GetAll( );
        }

        public Contact GetById ( int id )
        {
            return _contactRepository.GetById(id);
        }

        public void Update ( Contact entity )
        {
            _contactRepository.Update(entity);
        }
    }
}
