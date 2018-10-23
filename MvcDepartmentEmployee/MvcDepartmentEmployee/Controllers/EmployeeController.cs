using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDepartmentEmployee.Models;

namespace MvcDepartmentEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int departmentid)
        {
            DepartmentContext departmentContext = new DepartmentContext();
            List<Employee> employee = departmentContext.Employees.Where(n => n.DepartmentId == departmentid).ToList();
            return View(employee);
        }
        public ActionResult Details(int id)
        {
            DepartmentContext departmentContext = new DepartmentContext();
            Employee employee = departmentContext.Employees.Single(n => n.EmployeeId == id);
            return View(employee);
        }
    }
}