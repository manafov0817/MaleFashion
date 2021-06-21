using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class NewArrivalManager : INewArrivalService
    {
        private readonly INewArrivalRepository _newArrivalRepository;
        public NewArrivalManager(INewArrivalRepository newArrivalRepository)
        {
            _newArrivalRepository = newArrivalRepository;
        }
        public void Create(NewArrival entity)
        {
            _newArrivalRepository.Create(entity);
        }

        public void Delete(NewArrival entity)
        {
            _newArrivalRepository.Delete(entity);
        }

        public List<NewArrival> GetAll()
        {
            return _newArrivalRepository.GetAll();
        }

        public NewArrival GetById(int id)
        {
            return _newArrivalRepository.GetById(id);
        }

        public void Update(NewArrival entity)
        {
            _newArrivalRepository.Update(entity);
        }
    }
}
