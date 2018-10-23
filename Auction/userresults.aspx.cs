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
public partial class userresults : System.Web.UI.Page
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Stright Auction Winner";
        da = new SqlDataAdapter("select * from result where type='stright'", cn);
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Label1.Text = "Dautch Auction Winner";
        da = new SqlDataAdapter("select * from result where type='dautch'", cn);
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Label1.Text = "Sealed Auction Winner";
        da = new SqlDataAdapter("select * from result where type='sealed'", cn);
        da.Fill(ds);
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
