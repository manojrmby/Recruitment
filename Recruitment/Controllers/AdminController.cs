using Recruitment.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recruitment.Controllers
{
    public class AdminController : Controller
    {
        [DAL.AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin)]
        public ActionResult Index()
        {
            return View();
        }
    }
}