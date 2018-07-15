using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Management.App.Models;

namespace Management.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        
        public ActionResult RegisterUserGo(RegisterUser newUser, string returnURL)
        {
            if(ModelState.IsValid)
            {
                // continue here
            }
            return View();
        }
        public ActionResult PasswordReset()
        {
            return View();
        }
        public ActionResult PasswordResetGo()
        {
            return View();
        }
    }
}