using CosmiComics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CosmiComics.Controllers
{
    
    public class UserController : Controller
    {
        private ProductDBContext db = new ProductDBContext();
        // GET: User
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin([Bind(Include = "Username,Password")]Login userLogin)
        {
            if (ModelState.IsValid)
            {
                bool result = FormsAuthentication.Authenticate(userLogin.Username, userLogin.Password);

                if (result)
                {
                    FormsAuthentication.SetAuthCookie(userLogin.Username, false);
                    return Redirect(Url.Action("", ""));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                }
            }
            return View();
        }

        
    }
}