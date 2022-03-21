using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Product498.Models;


namespace Product498.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public String Index(String s)
        {
            return "ten tui la " + s;
        }

        public ActionResult ListProduct()
        {
            var product = new List<string>();
            product.Add("Starcraft");
            product.Add("Stardew valey");
            product.Add("Deep rock galactic");
            product.Add("Phasmophobia");
            product.Add("COM3D2");
            ViewBag.product = product;
            return View();
        }

        static List<Product> product = new List<Product>();

        public ActionResult GetListproduct()
        {
            if (product.Count() == 0)
            {
                product.Add(new Product(1, "Starcraft", "RTS", 10000000000,1, "/Content/images/Laptrinh.png"));
                product.Add(new Product(2, "Stardew valey", "RPG", 10000000000,2, "/Content/images/Laptrinh.png"));
                product.Add(new Product(3, "Deep rock galactic", "FPS", 10000000000,3, "/Content/images/Laptrinh.png"));
                product.Add(new Product(4, "Phasmophobia","simulation", 10000000000, 4, "/Content/images/Laptrinh.png"));
                product.Add(new Product(5, "COM3D2","3D", 10000000000, 5, "/Content/images/Laptrinh.png"));
            }
            return View(product);
        }

    }
}