using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;
using System.Collections.Generic;

namespace WebApplication19.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
            EmployeeDBcontext employeeDBcontext = new EmployeeDBcontext();
            EmployeeClass employee = employeeDBcontext.Employees.SingleOrDefault(n => n.EmployeeId == id);      
                return View(employee);
        }
    }
}