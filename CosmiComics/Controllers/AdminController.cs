using CosmiComics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CosmiComics.Controllers
{
    public class AdminController : Controller
    {
        //ADmin login actions
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login([Bind(Include = "Username,Password")]AdminLogin adminLogin)
        {
            if (ModelState.IsValid)
            {
                if (adminLogin.Username == "Admin")
                {
                    if (adminLogin.Password == "Admin")
                    {
                        return RedirectToAction("AdminIndex", "Admin");
                    }
                    return View();
                }
                return View();
            }
            return View();
        }
        // Admin page afer he logs in
        private ProductDBContext db = new ProductDBContext();
        public ActionResult AdminIndex()
        {
            ViewBag.MusicView = db.Music.ToList();
            ViewBag.MovieView = db.Movies.ToList();
            ViewBag.BookView = db.Books.ToList();
            return View();
        }
    }
}