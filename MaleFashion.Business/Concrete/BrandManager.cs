﻿using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandRepository _brandRepository;
        public BrandManager ( IBrandRepository brandRepository )
        {
            _brandRepository = brandRepository;
        }
        public void Create ( Brand entity )
        {
            
            _brandRepository.Create(entity);
        }

        public void Delete ( Brand entity )
        {
            _brandRepository.Delete(entity);
        }

        public List<Brand> GetAll ()
        {
            return _brandRepository.GetAll( );
        }

        public Brand GetById ( int id )
        {
            return _brandRepository.GetById(id);
        }

        public void Update ( Brand entity )
        {
            _brandRepository.Update(entity);
        }
    }
}
