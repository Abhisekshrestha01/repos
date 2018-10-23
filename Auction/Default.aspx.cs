using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
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
            cmd = new SqlCommand("select uid,pwd from newuser where uid='" + TextBox1.Text + "' and pwd='" + TextBox2.Text + "'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["user"] = TextBox1.Text;
                Server.Transfer("usermain.aspx");
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "Invalid UserName and Password";
            }
        }
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Server.Transfer("usersignup.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Server.Transfer("Default2.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
    }
}