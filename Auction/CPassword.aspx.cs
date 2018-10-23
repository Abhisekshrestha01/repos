using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auction
{
    public partial class CPassword : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "update newuser set pwd='"+ FormsAuthentication.HashPasswordForStoringInConfigFile(txtpassword.Text, "md5") + "' where uid = '"+ Session["username"] +"' and SQ = '"+ Session["mname"] +"'";
            cn.Open();
            SqlCommand sqlCmd = new SqlCommand(s, cn);

            sqlCmd.ExecuteNonQuery();
            cn.Close();
            //string sql= "insert newuser values('" + txtname.Text + "','" + txtuname.Text + "','" + txtpwd.Text + "'," + txtmobile.Text + ",'" + txtemail.Text + "','" + txtccno.Text + "','" + txtsname.Text + "','" + txtcity.Text + "','" + txtcountry.Text + "'," + txtpincode.Text + )";
            //Label1.Visible = false;
            //da = new SqlDataAdapter("insert newuser values('" + txtname.Text + "','" + txtuname.Text + "','" + txtpwd.Text + "'," + txtmobile.Text + ",'" + txtemail.Text + "','" + txtccno.Text + "','" + txtsname.Text + "','" + txtcity.Text + "','" + txtcountry.Text + "'," + txtpincode.Text + ")", cn);
            //da.Fill(ds);
            Response.Write("<script>alert('Values are Inserted')</script>");
            Response.Redirect("Default1.aspx");
            clear();

        }
        public void clear()
        {
            txtpassword.Text = "";
            txtcpassword.Text = "";
         

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default1.aspx");
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default3.aspx");
        }

    }
}