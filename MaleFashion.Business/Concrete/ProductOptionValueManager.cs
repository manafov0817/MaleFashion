﻿using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class ProductOptionValueManager : IProductOptionValueService
    {
        private IProductOptionValueRepository _productOptionValueRepository;
        public ProductOptionValueManager ( IProductOptionValueRepository productOptionValueRepository )
        {
            _productOptionValueRepository = productOptionValueRepository;
        }
        public void Create ( ProductOptionValue entity )
        {
            _productOptionValueRepository.Create(entity);
        }

        public void Delete ( ProductOptionValue entity )
        {
            _productOptionValueRepository.Delete(entity);
        }

        public List<ProductOptionValue> GetAll ()
        {
            return _productOptionValueRepository.GetAll( );
        }

        public ProductOptionValue GetById ( int id )
        {
            return _productOptionValueRepository.GetById(id);
        }

        public void Update ( ProductOptionValue entity )
        {
            _productOptionValueRepository.Update(entity);
        }
    }
}
