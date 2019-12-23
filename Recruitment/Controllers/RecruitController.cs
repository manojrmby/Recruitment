using Recruitment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recruitment.Controllers
{
    public class RecruitController : Controller
    {
        BaseClass BaseClass = new BaseClass();
        public ActionResult Enquery()
        {
            if(BaseClass.RoleName=="Admin")
            {
                return View();
            }
            return RedirectToAction("Login", "Login");
        }

    }
}