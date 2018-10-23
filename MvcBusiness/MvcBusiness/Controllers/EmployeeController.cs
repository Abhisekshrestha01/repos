using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using businessLayer;

namespace MvcBusiness.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer =
             new EmployeeBusinessLayer();

            List<Employee> employees = employeeBusinessLayer.Employees.ToList();
            return View(employees);
        }
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {

            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {

            Employee employee = new Employee();
            TryUpdateModel(employee);
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer =
                new EmployeeBusinessLayer();

                employeeBusinessLayer.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee = employeeBusinessLayer.Employees.Single(n => n.Id == id);
            return View(employee);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            Employee employee  = employeeBusinessLayer.Employees.Single(n => n.Id == id);
            UpdateModel<IEmployee>(employee);
            if (ModelState.IsValid)
            {

                employeeBusinessLayer.SaveEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //Using Bind include Insert
        //public ActionResult Edit_Post([Bind(Include = "Id, Gender, City, DateOfBirth")]Employee employee)
        //{
        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    employee.Name = employeeBusinessLayer.Employees.Single(n => n.Id == employee.Id).Name;

        //    if (ModelState.IsValid)
        //    {

        //        employeeBusinessLayer.SaveEmployee(employee);
        //        return RedirectToAction("Index");
        //    }
        //    return View(employee);
        //}

        //Using include and exclude list
        //public ActionResult Edit_Post(int id)
        //{
        //    EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
        //    Employee employee = employeeBusinessLayer.Employees.Single(n => n.Id == id);
        //    UpdateModel(employee, new strong[]{"Id, "Gender", "City", "DateOdBirth" } );
        //    if (ModelState.IsValid)
        //    {

        //        employeeBusinessLayer.SaveEmployee(employee);
        //        return RedirectToAction("Index");
        //    }
        //    return View(employee);
        //}
        [HttpPost]
        public ActionResult Delete(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            employeeBusinessLayer.DeleteEmployee(id);
            return RedirectToAction("Index");
        }



    }
}