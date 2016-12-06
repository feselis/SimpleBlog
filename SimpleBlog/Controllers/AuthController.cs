using SimpleBlog.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login()
        {
            return View(new AuthLogin() {
                Username = "Oi, Felipe!"
            });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {

            if (form.Username != "Felipe")
            {
                return View();
            }

            return Content("Olá, " + form.Username);
        }
    }
}
