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
        DBEmployee DBEmp = new DBEmployee();
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

        public JsonResult List()
        {

            return Json(DBEmp.listAll(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Add(EmployeeModel emp)
        {
            return Json(DBEmp.Add(emp), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update(EmployeeModel emp)
        {
            return Json(DBEmp.Update(emp), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int ID)
        {
            return Json(DBEmp.Delete(ID), JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetbyID(int ID)
        {
            var Employee = DBEmp.listAll().Find(x => x.ID.Equals(ID));
            return Json(Employee, JsonRequestBehavior.AllowGet);
        }
    }
}