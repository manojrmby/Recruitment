using Recruitment.DAL;
using Recruitment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Recruitment.Controllers
{
    public class EmployeeController : Controller
    {
        DBModels DBModels = new DBModels();
        // GET: Employee
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin +","+ DBHelper.Role.Employee)]
        public ActionResult CURD_Employee()
        {
            
                return View();
            
        }
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin + "," + DBHelper.Role.Employee)]
        public JsonResult List()
        {
        return Json(DBModels.listAll_Emp(), JsonRequestBehavior.AllowGet);
        }
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin + "," + DBHelper.Role.Employee)]
        public JsonResult Add(EmployeeModel emp)
        {
            return Json(DBModels.Add_Emp(emp), JsonRequestBehavior.AllowGet);
        }
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin + "," + DBHelper.Role.Employee)]
        public JsonResult Update(EmployeeModel emp)
        {
            return Json(DBModels.Update_Emp(emp), JsonRequestBehavior.AllowGet);
        }
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin + "," + DBHelper.Role.Employee)]
        public JsonResult Delete(int ID)
        {
            return Json(DBModels.Delete_Emp(ID), JsonRequestBehavior.AllowGet);
        }
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin + "," + DBHelper.Role.Employee)]
        public JsonResult GetbyID(int ID)
        {
            var Employee = DBModels.listAll_Emp().Find(x => x.ID.Equals(ID));
            return Json(Employee, JsonRequestBehavior.AllowGet);
        }

    }
}