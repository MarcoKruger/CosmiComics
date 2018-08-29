using CosmiComics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CosmiComics.Controllers
{
    public class AdminController : Controller
    {
        //ADmin login actions
        public ActionResult AdminLogin()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult AdminLogin([Bind(Include = "Username,Password")]Login adminLogin)
        {
            if (ModelState.IsValid)
            {
                bool result = FormsAuthentication.Authenticate(adminLogin.Username, adminLogin.Password);

                if (result)
                {
                    FormsAuthentication.SetAuthCookie(adminLogin.Username, false);
                    return RedirectToAction(Url.Action("AdminIndex", "Admin"));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                }
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