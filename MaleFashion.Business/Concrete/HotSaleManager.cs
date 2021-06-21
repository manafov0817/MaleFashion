using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaleFashion.Business.Concrete
{
    public class HotSaleManager : IHotSaleService
    {
        private readonly IHotSaleRepository _hotSaleRepository;
        public HotSaleManager(IHotSaleRepository hotSaleRepository)
        {
            _hotSaleRepository = hotSaleRepository;
        }
        public void Create(HotSale entity)
        {
            _hotSaleRepository.Create(entity);
        }

        public void Delete(HotSale entity)
        {
            _hotSaleRepository.Delete(entity);
        }

        public List<HotSale> GetAll()
        {
            return _hotSaleRepository.GetAll();
        }

        public HotSale GetById(int id)
        {
            return _hotSaleRepository.GetById(id);
        }

        public void Update(HotSale entity)
        {
            _hotSaleRepository.Update(entity);
        }
    }
}
