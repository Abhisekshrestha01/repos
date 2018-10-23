using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        IList<Student> studentList = new List<Student>() {
                    new Student(){ StudentId=1, StudentName="John", StudentAge = 18 },
                    new Student(){ StudentId=2, StudentName="Steve", StudentAge = 21 },
                    new Student(){ StudentId=3, StudentName="Bill", StudentAge = 25 },
                    new Student(){ StudentId=4, StudentName="Ram", StudentAge = 20 },
                    new Student(){ StudentId=5, StudentName="Ron", StudentAge = 31 },
                    new Student(){ StudentId=6, StudentName="Chris", StudentAge = 17 },
                    new Student(){ StudentId=7, StudentName="Rob", StudentAge = 19 }
                };
        public ActionResult Index()
        {

            // Get the students from the database in the real application
            ViewBag.count = studentList.Count();
            ViewData["MaxAge"] = studentList.Where(n => n.StudentAge > 20).First().StudentAge;
            return View(studentList);
        }
        public ActionResult Index1(int Id)
        {
            var std = studentList.Where(x => x.StudentId == Id).FirstOrDefault();
            return View(std);
        }
        public ActionResult Edit(int Id)
        {

            var std = studentList.Where(x => x.StudentId == Id).FirstOrDefault();
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (ModelState.IsValid)
            {
                var st = studentList.Where(x => x.StudentId == std.StudentId).FirstOrDefault();
                st.StudentName = std.StudentName;
                st.StudentAge = std.StudentAge;
                return RedirectToAction("Index");
            }
            return View(std);

        }
    }

}
