using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Student> qyeryStudent = from student in Student.GetAllStudent()
                                                where student.Gender == "Male"
                                                select student;
            GridView1.DataSource = qyeryStudent;

            //IEnumerable<Student> queryResult = Student.GetAllStudent().Where(student => student.Gender == "Male");
            //GridView1.DataSource = queryResult;
            GridView1.DataBind();
        }
    }
}