using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IndexesUsedPractise
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();
            Response.Write("Name of Employee with Id = 2 :" + company[2]);
            Response.Write("<br/>");
            Response.Write("Change name of employee for ID = 2");
            Response.Write("<br/>");
            company[2] = "Employee name changed";
            Response.Write("<br/>");
            Response.Write("Changed name of Employee with Id = 2 :" + company[2]);
            Response.Write("<br/>");

        }
    }
}