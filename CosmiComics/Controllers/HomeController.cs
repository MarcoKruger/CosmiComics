using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CosmiComics.Models;

namespace CosmiComics.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ProductDBContext db = new ProductDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult OverView()
        {
            List<Products> productList = new List<Products>();

            foreach (var item in db.Books)
            {
                productList.Add(new Products() { Name = item.Name, Image = item.Image, Price = item.Price });
            }
            foreach (var item in db.Music)
            {
                productList.Add(new Products() { Name = item.Name, Image = item.Image, Price = item.Price });
            }
            foreach (var item in db.Movies)
            {
                productList.Add(new Products() { Name = item.Name, Image = item.Image, Price = item.Price });
            }
            ViewBag.Products = productList;
            return View();
        }
    }
}