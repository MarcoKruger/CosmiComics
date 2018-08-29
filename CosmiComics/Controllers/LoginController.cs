using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CosmiComics.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult AccountType()
        {
            return View();
        }
    }
}