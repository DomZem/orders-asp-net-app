using Microsoft.AspNetCore.Mvc;
using orders_asp_net_app.Models;

namespace orders_asp_net_app.Controllers
{
    public class ProductController : Controller
    {
        public readonly static IList<Product> ProductList = new List<Product>
        {
           new Product()
           { 
                Id = 1,
                Name = "Smartphone",
                Description = "Latest model smartphone with high-resolution camera",
                Price = 599.99m,
                Weight = 0.3m,
                Quantity = 100,
                Category = ProductCategory.ELECTRONICS
           },
           new Product() 
           {
                Id = 2,
                Name = "Men's T-Shirt",
                Description = "Comfortable cotton T-shirt for men",
                Price = 19.99m,
                Weight = 0.2m,
                Quantity = 200,
                Category = ProductCategory.FASHION
           },
           new Product()
           {
                Id = 3,
                Name = "Vitamins",
                Description = "Multivitamins for daily health",
                Price = 9.99m,
                Weight = 0.05m,
                Quantity = 500,
                Category = ProductCategory.HEALTH
           },
           new Product()
           {
                Id = 4,
                Name = "Gaming Console",
                Description = "Next-gen gaming console for immersive gaming experience",
                Price = 499.99m,
                Weight = 4.0m,
                Quantity = 50,
                Category = ProductCategory.ENTERTAINMENT
           },
           new Product() {
                Id = 5,
                Name = "Running Shoes",
                Description = "High-performance running shoes for athletes",
                Price = 79.99m,
                Weight = 0.5m,
                Quantity = 150,
                Category = ProductCategory.SPORT
           }
        };

        // GET: ProductController
        public ActionResult Index()
        {
            return View(ProductList);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
