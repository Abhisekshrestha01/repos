using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelpers.Models;

namespace HtmlHelpers.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee employee = new Employee("Mark");
            ViewBag.department = new SelectList(employee.GetDepartment, "Id", "Name");
            ViewBag.Name = employee.CompanyName;
            return View();
        }

        public ActionResult Index1()
        {
            Employee employee = new Employee("Mark");
            return View(employee);
        }
        [HttpGet]
        public ActionResult Index2()
        {
            Employee employee = new Employee("Mark");
            return View(employee);
        }
        [HttpPost]
        
        public string Index2(Employee employee)
        {
            if(string.IsNullOrEmpty(employee.SelectedDepartment))
            {
                return "You did not select any department";
            }
            else
            {
                return "You selected department with ID = " + employee.SelectedDepartment;
            }
           
        }
    }
}