using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication20
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String cs = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=Employees;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Select * from tblEmployee", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            GridView1.DataSource = sdr;
            GridView1.DataBind();
        }
    }
}