using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Entitypractise
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeDBContext db = new EmployeeDBContext();
            GridView1.DataSource = db.Employees.ToList();
            GridView1.DataBind();
        }
    }
}