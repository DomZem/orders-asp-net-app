using Microsoft.AspNetCore.Mvc;
using orders_asp_net_app.Models;

namespace orders_asp_net_app.Controllers
{
    public class OrderController : Controller
    {
        private static IList<Order> OrdersList = new List<Order>()
        {
            new Order() 
            {
                Id = 1,
                Date = DateTime.Now,
                Products = new Product[] { ProductController.ProductList[0], ProductController.ProductList[1] },
                ClientName = "John Doe",
                ClientAddress = "123 Main St, City",
                ClientPhone = 333444555,
                PaymentMethod = Payment.CASH
            },
            new Order() 
            {
                Id = 2,
                Date = DateTime.Now,
                Products = new Product[] { ProductController.ProductList[2], ProductController.ProductList[3] },    
                ClientName = "Alice Smith",
                ClientAddress = "456 Elm St, Town",
                ClientPhone = 444555666,
                PaymentMethod = Payment.CREDIT
            }
        };

        // GET: OrderController
        public ActionResult Index()
        {
            return View(OrdersList);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View(OrdersList.FirstOrDefault(order => order.Id == id));
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
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

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
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
