using MaleFashion.Data.Abstract;
using MaleFashion.Entity.ViewComponentModel;
using Microsoft.AspNetCore.Mvc;


namespace MaleFashion.WebUi.Components
{
    public class InstagramViewComponent : ViewComponent
    {
        private readonly IInstagramProfileRepository _instagramProfileRepository;

        public InstagramViewComponent(IInstagramProfileRepository instagramProfileRepository)
        {
            _instagramProfileRepository = instagramProfileRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(_instagramProfileRepository.Get());
        }
    }
}
