using Microsoft.AspNetCore.Mvc;
using SPU123_Shop_MVC.Models;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data.Entities;
using Data;

namespace SPU123_Shop_MVC.Controllers
{
    public class ProductsController : Controller
    {
        private ShopDbContext context;

        public ProductsController(ShopDbContext context)
        {
            this.context = context;
        }
        private void LoadCategories()
        {
            ViewBag.CategoryList = new SelectList(context.Categories.ToList(), "Id", "Name");
        }
        public IActionResult Index()
        {
            
            //List<Product> products = context.Products.ToList();

            List<Product> products = context.Products.Include(x => x.Category).ToList();

            return View(products);
        }
        public IActionResult Create()
        {
            LoadCategories();


            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid) // using model metadata
            {
                return View("Create");
            }

            context.Products.Add(product);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var product = context.Products.Find(id);

            if (product == null) return NotFound();

            LoadCategories();

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            
            if (!ModelState.IsValid)
            {
                return View("Edit");
            }

            context.Products.Update(product);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {

            var item = context.Products.Find(id);

            if (item == null)
                return NotFound();

            context.Products.Remove(item);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var item = context.Products.Find(id);

            if (item == null)
                return NotFound();

            return View(item);
        }
    }
}