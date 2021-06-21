using MaleFashion.Business.Abstract;
using MaleFashion.Data.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using System.Collections.Generic;

namespace MaleFashion.Business.Concrete
{
    public class InstagramProfileManager : IInstagramProfileService
    {
        private readonly IInstagramProfileRepository _instagramProfileRepository;
        public InstagramProfileManager(IInstagramProfileRepository instagramProfileRepository)
        {
            _instagramProfileRepository = instagramProfileRepository;
        }
        public void Create(InstagramProfile entity)
        {
            _instagramProfileRepository.Create(entity);
        }

        public void Delete(InstagramProfile entity)
        {
            _instagramProfileRepository.Delete(entity);
        }

        public InstagramProfile Get()
        {
            return _instagramProfileRepository.Get();
        }

        public List<InstagramProfile> GetAll()
        {
            return _instagramProfileRepository.GetAll();
        }

        public InstagramProfile GetById(int id)
        {
            return _instagramProfileRepository.GetById(id);
        }

        public void Update(InstagramProfile entity)
        {
            _instagramProfileRepository.Update(entity);
        }
    }
}
