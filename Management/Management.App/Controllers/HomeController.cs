using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Management.App.Models;
using Management.Data;
using Management.Domain.Models;
using System.Web.Configuration;

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
            RegisterUser model = new RegisterUser();       
            return View(model);
        }

        [HttpPost]
        public ActionResult RegisterUserGo(RegisterUser user)
        {
            if(ModelState.IsValid)
            {
                string constring = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                Database database = new Database(constring);
                User newUser = new User();
                newUser.FirstName = user.FirstName;
                newUser.LastName = user.LastName;
                newUser.EmailAddress = user.EmailAddress;
                newUser.Password = user.Password;
                database.AddUser(newUser);
                return RedirectToAction("Login");
            }
            return View("Register",user);
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