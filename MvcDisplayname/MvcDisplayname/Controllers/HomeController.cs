using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDisplayname.Models;
using System.Data.Entity;

namespace MvcDisplayname.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Details(int id)
        {
            EmployeeContext db = new EmployeeContext();
            Employee employee = db.Employees.Single(n => n.Id == id);

           
            return View(employee);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeContext db = new EmployeeContext();
            Employee employee = db.Employees.Single(n => n.Id == id);

            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Exclude = " ")] Employee employee)
        {
            EmployeeContext db = new EmployeeContext();
            Employee employeeFromDB = db.Employees.Single(x => x.Id == employee.Id);

            // Populate all the properties except EmailAddrees
            employeeFromDB.FullName = employee.FullName;
            employeeFromDB.Gender = employee.Gender;
            employeeFromDB.Age = employee.Age;
            employeeFromDB.HireDate = employee.HireDate;
            employeeFromDB.Salary = employee.Salary;
            employeeFromDB.PersonalWebSite = employee.PersonalWebSite;

            if (ModelState.IsValid)
            {
                db.Entry(employeeFromDB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", new { id = employee.Id });
            }

        

            return View(employee);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}