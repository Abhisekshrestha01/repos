using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;



public partial class usersignup : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection();
    SqlDataAdapter da;
    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        //cn.ConnectionString = System.Configuration.ConfigurationManager.AppSettings.Get("gvs");
        //cn.ConnectionString = "Integrated Security=true;Initial Catalog=NetAuction;Data Source=.";
        cn.ConnectionString = "Data Source=DESKTOP-9V6EBK0;Initial Catalog=NetAuction;Integrated Security=True";

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
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
        else
        {
            Label1.Visible = false;
            da = new SqlDataAdapter("insert newuser values('" + txtname.Text + "','" + txtuname.Text + "','" + FormsAuthentication.HashPasswordForStoringInConfigFile(txtpwd.Text, "md5") + "'," + txtmobile.Text + ",'" + txtemail.Text + "','" + txtccno.Text + "','" + txtsname.Text + "','" + txtcity.Text + "','" + txtcountry.Text + "'," + txtpincode.Text + ")", cn);
            da.Fill(ds);
            Response.Write("<script>alert('Values are Inserted')</script>");
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
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        clear();
    }
}
