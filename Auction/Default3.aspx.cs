using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auction
{
    public partial class Default3 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            cn.ConnectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";
        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default1.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Label3.Visible = true;
                Label3.Text = "Must Enter Username";
            }
            else if (TextBox2.Text == "")
            {
                Label3.Visible = true;
                Label3.Text = "Must Enter Password";
            }
            else
            {
                Label3.Visible = false;
                cmd = new SqlCommand("select * from adminlogin where uid='" + TextBox1.Text + "' and pwd='" + TextBox2.Text + "'", cn);
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Response.Redirect("adminmain1.aspx");
                }
                else
                {
                    Label3.Visible = true;
                    Label3.Text = "Invalid UserName and Password";
                    TextBox1.Text = "";
                }
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default3.aspx");
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default1.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default1.aspx");
        }
    }
}