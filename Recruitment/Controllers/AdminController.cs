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
        public ActionResult RoleMaster()
        {
            DBModels dBModels = new DBModels();
            return View(dBModels.listAll_Role());
        }

        //public JsonResult RoleList()
        //{
        //    DBModels dBModels = new DBModels();
        //    return Json(dBModels.listAll_Role(), JsonRequestBehavior.AllowGet);
        //}
    }
} 