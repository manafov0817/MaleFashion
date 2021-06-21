using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class BestSellerManager : IBestSellerService
    {
        private readonly IBestSellerRepository _bestSellerRepository;
        public BestSellerManager(IBestSellerRepository bestSellerRepository)
        {
            _bestSellerRepository = bestSellerRepository;
        }
        public void Create(BestSeller entity)
        {
            _bestSellerRepository.Create(entity);
        }

        public void Delete(BestSeller entity)
        {
            _bestSellerRepository.Delete(entity);
        }

        public List<BestSeller> GetAll()
        {
            return _bestSellerRepository.GetAll();
        }

        public BestSeller GetById(int id)
        {
            return _bestSellerRepository.GetById(id);
        }

        public void Update(BestSeller entity)
        {
            _bestSellerRepository.Update(entity);
        }
    }
}
