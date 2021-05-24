using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class BrandsModelManager : IBrandsModelService
    {
        private IBrandModelRepository _brandModelRepository;
        public BrandsModelManager ( IBrandModelRepository brandModelRepository )
        {
            _brandModelRepository = brandModelRepository;
        }
        public void Create ( BrandsModel entity )
        {
            _brandModelRepository.Create(entity);
        }

        public void Delete ( BrandsModel entity )
        {
            _brandModelRepository.Delete(entity);
        }

        public List<BrandsModel> GetAll ()
        {
            return _brandModelRepository.GetAll( );
        }

        public List<BrandsModel> GetBrandsModelsWithBrands ()
        {
            return _brandModelRepository.GetBrandModelsWithBrands( );
        }

        public BrandsModel GetById ( int id )
        {
            return _brandModelRepository.GetById(id);
        }

        public List<BrandsModel> GetModelsByBrandId ( int id )
        {
            return _brandModelRepository.GetModelsByBrandId(id);
        }

        public void Update ( BrandsModel entity )
        {
            _brandModelRepository.Update(entity);
        }
    }
}
