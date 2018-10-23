using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataFirstBridgeTable
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDBcontext employeeDBcontext = new EmployeeDBcontext();
            GridView1.DataSource = (from student in employeeDBcontext.Students
                                    
                                    from sC in employeeDBcontext.StudentCourses
                                    select new
                                    {
                                        StudentName = student.StudentName,
                                        CouresName = sC.Cours.CourseName,
                                        EnrolledDate = sC.EnrolledDate
                                    }).ToList();
            GridView1.DataBind();

        }

        
    }
}