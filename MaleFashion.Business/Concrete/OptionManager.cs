using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class OptionManager : IOptionService
    {
        private IOptionRepository _optionRepository;
        public OptionManager ( IOptionRepository optionRepository )
        {
            _optionRepository = optionRepository;
        }
        public void Create ( Option entity )
        {
            _optionRepository.Create(entity);
        }

        public void Delete ( Option entity )
        {
            _optionRepository.Delete(entity);
        }

        public List<Option> GetAll ()
        {
            return _optionRepository.GetAll( );
        }

        public Option GetById ( int id )
        {
            return _optionRepository.GetById(id);
        }
        public Option GetByName ( string value )
        {
            return _optionRepository.GetByName(value);
        }
        public void Update ( Option entity )
        {
            _optionRepository.Update(entity);
        }
    }
}
