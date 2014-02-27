using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace $safeprojectname$.Models
{
    public class AppViewModel
    {
        private LoginUser currentUser;

        public LoginUser CurrentUser {
            get {
                if (System.Web.HttpContext.Current.Session["User"] != null) {
                    this.currentUser = (LoginUser)System.Web.HttpContext.Current.Session["User"];
                }
                return this.currentUser; }
            set { this.currentUser = value; }
        }

        public AppViewModel() {
        }
    }
}