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
    public partial class Changepassword1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlDataAdapter da;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter Username";
            }
            else if (txtmothername.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter Security Question";
            }
            else if (txtmobileno.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter Phone no.";
            }
            else
            {
                cn.Open();
                SqlCommand Check_if_exists = new SqlCommand("SELECT COUNT(1) FROM newuser WHERE uid = '" +txtusername.Text+ "' and mobile = '" +txtmobileno.Text+ "' and SQ = '" + FormsAuthentication.HashPasswordForStoringInConfigFile(txtmothername.Text, "md5")+ "'", cn);
                int UserExist = (int) Check_if_exists.ExecuteScalar();
                if(UserExist > 0)
                {
                    Session["username"] = txtusername.Text;
                    Session["mname"] = FormsAuthentication.HashPasswordForStoringInConfigFile(txtmothername.Text,"md5");
                    Response.Redirect("CPassword.aspx");
                    //Response.Write("User do exists");
                }
                else
                {
                    Response.Write("User does not exists");
                }
                
                cn.Close();
            
            }

        }
        public void clear()
        {
            txtusername.Text = "";
            txtmothername.Text = "";
            txtmobileno.Text = "";
            
        }
        protected void btn_reset_Click(object sender, EventArgs e)
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