using CustomAuthProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Index(LoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                if (vm.Email == "test@microsoft.com" && vm.Password == "P@ssword")
                {
                    Session["user"] = vm.Email;
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Wrong email or password!");
            }
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            Session.Remove("user");
            return RedirectToAction("Index");
        }
    }
}