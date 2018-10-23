using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication28
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownEntities dbconet = new DropDownEntities();
            GridView1.DataSource = dbconet.tblEmployees.ToList();
            GridView1.DataBind();
        }
    }
}