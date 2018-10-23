using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace databaseFirstManyToM
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDbconnection employeeDBContext = new EmployeeDbconnection();

            GridView1.DataSource = (from student in employeeDBContext.Students
                                    from course in student.Courses
                                    select new
                                    {
                                        StudentName = student.StudentName,
                                        CourseName = course.CourseName
                                    }).ToList();
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //EmployeeDbEntities employeeDBcontext = new EmployeeDbEntities();
            //Cours WCFCourse = employeeDBcontext.Courses.FirstOrDefault(n => n.CourseID == 4);
            //employeeDBcontext.Students.FirstOrDefault(n => n.StudentID == 1).Courses.Add(WCFCourse);
            //employeeDBcontext.SaveChanges();
            
        }
    }
}