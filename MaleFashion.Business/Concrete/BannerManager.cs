using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class BannerManager : IBannerService
    {
        public readonly IBannerRepository _bannerRepository;
        public BannerManager(IBannerRepository bannerRepository)
        {
            _bannerRepository = bannerRepository;
        }
   
        public void Create(Banner entity)
        {
            _bannerRepository.Create(entity);
        }

        public void Delete(Banner entity)
        {
            _bannerRepository.Delete(entity);
        }

        public List<Banner> GetAll()
        {
            return _bannerRepository.GetAll();
        }

        public Banner GetById(int id)
        {
            return _bannerRepository.GetById(id);
        }

        public void Update(Banner entity)
        {
            _bannerRepository.Update(entity);
        }
    }
}
