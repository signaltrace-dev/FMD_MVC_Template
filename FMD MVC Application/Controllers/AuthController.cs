using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using $safeprojectname$.Models;
using System.Web.Security;

namespace $safeprojectname$.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login() {
            return View();
        }

        public ActionResult ShowUserInfo() {
            LoginUser u = new LoginUser();
            if (Session["User"] != null)
            {
                u = (LoginUser)Session["User"];
            }

            else {
                RedirectToAction("Login");
            }

            return View("~/Views/Shared/_UserInfo.cshtml", u);
        }

        [HttpPost]
        public ActionResult Login(LoginUser user, string returnUrl) {

            user.Authenticate();
            if (user.IsAuthenticated) {

                Session["User"] = user;
                FormsAuthentication.SetAuthCookie(user.UserName, false);
            

                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("", "");
                }

            }

            return View(user);
            
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session["User"] = null;
            Session.Clear();
            Session.Abandon();

            return RedirectToAction("", "");
        }
         
    }
}
