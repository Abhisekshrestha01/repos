using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCajax.Models;

namespace MVCajax.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDbEntities db = new EmployeeDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult All()
        {
            List<Student> model = db.Students.ToList();
            return PartialView("_student", model);
        }
        public PartialViewResult Top3()
        {
            List<Student> model = db.Students.OrderByDescending(n => n.TotalMarks).Take(3).ToList();
            return PartialView("_student", model);
        }
        public ActionResult Bottom3()
        {
            List<Student> model = db.Students.OrderBy(n => n.TotalMarks).Take(3).ToList();
            return PartialView("_student", model);
        }
    }
}