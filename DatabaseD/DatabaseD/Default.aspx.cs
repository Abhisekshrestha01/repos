using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseD
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string connectionstring = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=DropDown;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionstring);
                SqlCommand cmd = new SqlCommand("SELECT Id, CityName, Country from Dropdown", con);
                con.Open();
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataBind();
                SqlDataReader sdr = cmd.ExecuteReader();
                GridView1.DataSource = sdr;
                GridView1.DataBind();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string m = RadioButton1.Text;
            string city = DropDownList1.Text;
            Response.Write("The name is "+ name + ", is a "+ m + ", and from "+ city);
        }
    }
}