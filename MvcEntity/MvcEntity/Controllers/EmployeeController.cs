using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEntity.Models;

namespace MvcEntity.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        public ActionResult Index()
        {
            EmployeeContext employeEContext = new EmployeeContext();
            List<Employee> employee = employeEContext.Employees.ToList();
            return View(employee);
        }
        public ActionResult Details(int id)
        {
            EmployeeContext employeEContext = new EmployeeContext();
            Employee employee = employeEContext.Employees.Single(n => n.EmployeeId == id);
            return View(employee);
        }
    }
}