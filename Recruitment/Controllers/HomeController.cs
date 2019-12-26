using Recruitment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Recruitment.Models;
namespace Recruitment.Controllers
{
    public class HomeController : Controller
    {
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin + "," + DBHelper.Role.Employee)]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

       
    }
}