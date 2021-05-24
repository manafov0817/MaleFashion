using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class HeroManager : IHeroService
    {
        private IHeroRepository _heroRepository;
        public HeroManager(IHeroRepository heroRepository)
        {
            _heroRepository = heroRepository;
        }

        public void Create(Hero entity)
        {
            _heroRepository.Create(entity);
        }

        public void Delete(Hero entity)
        {
            _heroRepository.Delete(entity);
        }

        public List<Hero> GetAll()
        {
            return _heroRepository.GetAll();
        }

        public Hero GetById(int id)
        {
            return _heroRepository.GetById(id);
        }

        public void Update(Hero entity)
        {
            _heroRepository.Update(entity);
        }
    }
}
