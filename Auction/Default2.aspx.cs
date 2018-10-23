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

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        //cn.ConnectionString = "Integrated Security=true;Initial Catalog=NetAuction;Data Source=.";
        cn.ConnectionString = "Data Source=DESKTOP-9V6EBK0;Initial Catalog=NetAuction;Integrated Security=True";
        //cn.ConnectionString = System.Configuration.ConfigurationManager.AppSettings.Get("gvs");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
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
                Server.Transfer("adminmain.aspx");
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
}
