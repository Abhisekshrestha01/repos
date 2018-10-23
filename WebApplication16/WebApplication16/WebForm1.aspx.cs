using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication16
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDbcontext employeeDBContext = new EmployeeDbcontext();

            GridView1.DataSource = from student in employeeDBContext.Students
                                   from course in student.Courses
                                   select new
                                   {
                                       StudentName = student.StudentName,
                                       CourseName = course.CourseName
                                   };
            GridView1.DataBind();
        }
     }
}