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
        DBEmployee DBEmp = new DBEmployee();
        // GET: Employee
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin +","+ DBHelper.Role.Employee)]
        public ActionResult CURD_Employee()
        {
            
                return View();
            
        }
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin + "," + DBHelper.Role.Employee)]
        public JsonResult List()
        {
        return Json(DBEmp.listAll(), JsonRequestBehavior.AllowGet);
        }
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin + "," + DBHelper.Role.Employee)]
        public JsonResult Add(EmployeeModel emp)
        {
            return Json(DBEmp.Add(emp), JsonRequestBehavior.AllowGet);
        }
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin + "," + DBHelper.Role.Employee)]
        public JsonResult Update(EmployeeModel emp)
        {
            return Json(DBEmp.Update(emp), JsonRequestBehavior.AllowGet);
        }
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin + "," + DBHelper.Role.Employee)]
        public JsonResult Delete(int ID)
        {
            return Json(DBEmp.Delete(ID), JsonRequestBehavior.AllowGet);
        }
        [AuthorizeRolesAttribute(UserRole = DBHelper.Role.Admin + "," + DBHelper.Role.Employee)]
        public JsonResult GetbyID(int ID)
        {
            var Employee = DBEmp.listAll().Find(x => x.ID.Equals(ID));
            return Json(Employee, JsonRequestBehavior.AllowGet);
        }

    }
}