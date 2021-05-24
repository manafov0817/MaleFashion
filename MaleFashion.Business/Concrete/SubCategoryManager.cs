using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        private ISubCategoryRepository _subCategoryRepository;
        public SubCategoryManager ( ISubCategoryRepository subCategoryRepository )
        {
            _subCategoryRepository = subCategoryRepository;
        }
        public void Create ( SubCategory entity )
        {
            _subCategoryRepository.Create(entity);
        }

        public void Delete ( SubCategory entity )
        {
            _subCategoryRepository.Delete(entity);
        }

        public List<SubCategory> GetAll ()
        {
            return _subCategoryRepository.GetAll( );
        }

        public List<SubCategory> GetAllSubCategoriesWithCategoryAndMainCategory ()
        {
            return _subCategoryRepository.GetAllSubCategoriesWithCategoryAndMainCategory( );
        }

        public SubCategory GetById ( int id )
        {
            return _subCategoryRepository.GetById(id);
        }

        public List<SubCategory> GetSubCategoriesByCategoryId ( int id )
        {
            return _subCategoryRepository.GetSubCategoriesByCategoryId(id);
        }

        public SubCategory GetSubCategoryWithCategoryAndMainCategorybyId ( int id )
        {
            return _subCategoryRepository.GetSubCategoryWithCategoryAndMainCategorybyId(id);
        }

        public void Update ( SubCategory entity )
        {
            _subCategoryRepository.Update(entity);
        }
    }
}
