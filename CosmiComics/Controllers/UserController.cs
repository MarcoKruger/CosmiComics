using CosmiComics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CosmiComics.Controllers
{
    public class UserController : Controller
    {
        private ProductDBContext db = new ProductDBContext();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index([Bind(Include = "Username,Password")]Login userLogin)
        {
            if (ModelState.IsValid)
            {
                if (userLogin.Username == "User")
                {
                    if (userLogin.Password == "User")
                    {
                        return RedirectToAction("AdminIndex", "Admin");
                    }
                    return View();
                }
                return View();
            }
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