using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class DealOfTheWeekManager : IDealOfTheWeekService
    {
        private readonly IDealOfTheWeekRepository _dealOfTheWeekRepository;
        public DealOfTheWeekManager(IDealOfTheWeekRepository dealOfTheWeekRepository)
        {
            _dealOfTheWeekRepository = dealOfTheWeekRepository;
        }

        public void Create(DealOfTheWeek entity)
        {
            _dealOfTheWeekRepository.Create(entity);
        }

        public void Delete(DealOfTheWeek entity)
        {
            _dealOfTheWeekRepository.Delete(entity);
        }

        public DealOfTheWeek Get()
        {
            return _dealOfTheWeekRepository.Get();
        }

        public List<DealOfTheWeek> GetAll()
        {
            return _dealOfTheWeekRepository.GetAll();
        }

        public DealOfTheWeek GetById(int id)
        {
            return _dealOfTheWeekRepository.GetById(id);
        }

        public void Update(DealOfTheWeek entity)
        {
            _dealOfTheWeekRepository.Update(entity);
        }
    }
}
