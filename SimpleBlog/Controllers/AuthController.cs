using SimpleBlog.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home"); //entender como o framework está obtendo esta rota, visto que o parâmetro está escrito como "home" e não "Home"
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View();

            FormsAuthentication.SetAuthCookie(form.Username, true);

            if (!string.IsNullOrWhiteSpace(returnUrl))
                return Redirect(returnUrl);

            return RedirectToRoute("home"); //entender como o framework está obtendo esta rota, visto que o parâmetro está escrito como "home" e não "Home"
        }
    }
}
