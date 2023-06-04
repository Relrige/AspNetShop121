using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPU123_Shop_MVC.Models;
using Data.Entities;
using System.Diagnostics;
namespace SPU123_Shop_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopDbContext context;

        public HomeController(ShopDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var products = context.Products.Include(x => x.Category).ToList();

            return View(products); // ~/Home/Index.cshtml
        }
    
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
