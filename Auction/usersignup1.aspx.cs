using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auction
{
    public partial class usersignup1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            //cn.ConnectionString = System.Configuration.ConfigurationManager.AppSettings.Get("gvs");
            //cn.ConnectionString = "Integrated Security=true;Initial Catalog=NetAuction;Data Source=.";
            cn.ConnectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";

        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default1.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        protected void btnreg_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter Name";
            }
            else if (txtuname.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter UserName";
            }
            else if (txtpwd.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter Password";
            }
            else if (txtmobile.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter Mobile Number";
            }
            else if (txtemail.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter E-MailId";
            }
            else if (txtccno.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter CreditCard Number";
            }
            else if (txtsname.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter Street Name";
            }
            else if (txtcity.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter City";
            }
            else if (txtcountry.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter Country Name";
            }
            else if (txtpincode.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter PinCode";
            }
            else if (txtsecurityquestion.Text == "")
            {
                Label1.Visible = false;
                Label1.Visible = true;
                Label1.Text = "Must Enter Security question";
            }
            else
            {
                string s = "insert into newuser(uname,uid,pwd,mobile,emailid ,crno ,stname,city ,country,pin,SQ) values('" + txtname.Text + "','" + txtuname.Text + "','" + FormsAuthentication.HashPasswordForStoringInConfigFile(txtpwd.Text, "md5") + "'," + txtmobile.Text + ",'" + txtemail.Text + "','" + txtccno.Text + "','" + txtsname.Text + "','" + txtcity.Text + "','" + txtcountry.Text + "','" + txtpincode.Text + "','" + FormsAuthentication.HashPasswordForStoringInConfigFile( txtsecurityquestion.Text,"md5") + "')";
                cn.Open();
                SqlCommand sqlCmd = new SqlCommand(s, cn);

                sqlCmd.ExecuteNonQuery();
                cn.Close();
                //string sql= "insert newuser values('" + txtname.Text + "','" + txtuname.Text + "','" + txtpwd.Text + "'," + txtmobile.Text + ",'" + txtemail.Text + "','" + txtccno.Text + "','" + txtsname.Text + "','" + txtcity.Text + "','" + txtcountry.Text + "'," + txtpincode.Text + )";
                //Label1.Visible = false;
                //da = new SqlDataAdapter("insert newuser values('" + txtname.Text + "','" + txtuname.Text + "','" + txtpwd.Text + "'," + txtmobile.Text + ",'" + txtemail.Text + "','" + txtccno.Text + "','" + txtsname.Text + "','" + txtcity.Text + "','" + txtcountry.Text + "'," + txtpincode.Text + ")", cn);
                //da.Fill(ds);
                //Response.Write("<script>alert('Values are Inserted')</script>");
                Response.Redirect("Default1.aspx");
                clear();
            }
        }
        public void clear()
        {
            txtname.Text = "";
            txtuname.Text = "";
            txtpwd.Text = "";
            txtrepwd.Text = "";
            txtmobile.Text = "";
            txtemail.Text = "";
            txtccno.Text = "";
            txtsname.Text = "";
            txtcity.Text = "";
            txtcountry.Text = "";
            txtpincode.Text = "";
            txtsecurityquestion.Text = "";
        }
        protected void btnreset_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default1.aspx");
        }
        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default3.aspx");
        }

    }
}