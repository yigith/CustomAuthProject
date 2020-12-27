using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomAuthProject.Helpers
{
    public static class Login
    {
        public static bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(HttpContext.Current.Session["user"] as string);
        }

        public static string UserName()
        {
            return HttpContext.Current.Session["user"] as string;
        }
    }
}