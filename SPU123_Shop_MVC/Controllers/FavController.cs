using Data;
using Microsoft.AspNetCore.Mvc;
using SPU123_Shop_MVC.Helpers;
using SPU123_Shop_MVC.Services;

namespace SPU123_Shop_MVC.Controllers
{
    public class FavController : Controller
    {
        private readonly ShopDbContext context;
        private readonly IFavoriteService favService;

        public FavController(ShopDbContext context, IFavoriteService favService)
        {
            this.context = context;
            this.favService = favService;
        }

        public IActionResult Index()
        {
           
            return View(favService.GetAll());
        }

        public IActionResult Add(int id)
        {
            favService.Add(id);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Remove(int id)
        {
            favService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}