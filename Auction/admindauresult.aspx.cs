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
public partial class admindauresult : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection();
    SqlCommand cmd;
    SqlDataReader dr;
    SqlCommand cmd1;
    SqlDataReader dr1;

    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        //cn.ConnectionString = System.Configuration.ConfigurationManager.AppSettings.Get("gvs");
        //cn.ConnectionString = "Integrated Security=true;Initial Catalog=NetAuction;Data Source=.";
        cn.ConnectionString = "Data Source=DESKTOP-9V6EBK0;Initial Catalog=NetAuction;Integrated Security=True";
        if (!IsPostBack)
        {
            data();
        }
    }
    public void data()
    {
        cmd = new SqlCommand("select itemid from item where type='dautch'", cn);
        cn.Open();
        dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr[0].ToString());
        }
        dr.Close();
        cn.Close();
    }
    string amount;
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select * from buyer where Itemid='" + DropDownList1.SelectedItem.Text + "'", cn);
        ds = new DataSet();
        da.Fill(ds);
        GridView2.DataSource = ds.Tables[0];
        GridView2.DataBind();

        cmd = new SqlCommand("select max(amount) from buyer where itemid=" + DropDownList1.SelectedItem.Text + "", cn);
        cn.Open();
        dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            amount = dr[0].ToString();
            result();
        }
        cn.Close();
        dr.Close();
    }
    public void result()
    {
        dr.Close();
        cmd1 = new SqlCommand("select * from buyer where amount=" + amount + " and itemid=" + DropDownList1.SelectedItem.Text + "", cn);

        dr1 = cmd1.ExecuteReader();
        if (dr1.Read())
        {
            TextBox1.Text = dr1[0].ToString();
            TextBox2.Text = dr1[1].ToString();
            TextBox3.Text = dr1[2].ToString();
            TextBox4.Text = dr1[4].ToString();
        }
        cn.Close();
        dr.Close();

    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        da = new SqlDataAdapter("select * from buyer where Itemid='" + DropDownList1.SelectedItem.Text + "'", cn);
        ds = new DataSet();
        da.Fill(ds);
        GridView2.DataSource = ds.Tables[0];
        GridView2.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s = "winner";
        string a = "dautch";
        da = new SqlDataAdapter("insert result values(" + TextBox1.Text + ",'" + TextBox2.Text + "'," + TextBox3.Text + ",'" + TextBox4.Text + "','" + s + "','" + a + "')", cn);
        ds = new DataSet();
        da.Fill(ds);
        Response.Write("<script>alert('Values are Submited')</script>");
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
}
