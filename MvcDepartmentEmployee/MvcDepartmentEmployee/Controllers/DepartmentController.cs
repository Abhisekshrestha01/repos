using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDepartmentEmployee.Models;

namespace MvcDepartmentEmployee.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            DepartmentContext departmentcontext = new DepartmentContext();

            return View(departmentcontext.Departments.ToList());
        }
        

    }
}