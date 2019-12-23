using Recruitment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recruitment.DAL;

namespace Recruitment.Controllers
{
    public class LoginController : Controller 
    {
        // GET: Login
        public ActionResult Login()
        {
            Session.Clear();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Login(LoginModel login)
        {
           BaseClass Log= new BaseClass();
          login= Log.loginValidate(login.UserName, login.Password);

           if (login.Empid!=null)
            {
                
                return RedirectToAction("Enquery", "Recruit");
            }
            return RedirectToAction("Login", "Login");
        }
    }
}