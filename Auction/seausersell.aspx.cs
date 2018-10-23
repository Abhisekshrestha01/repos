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

public partial class seausersell : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection();
    SqlDataAdapter da;
    DataSet ds = new DataSet();

    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        //cn.ConnectionString = System.Configuration.ConfigurationManager.AppSettings.Get("gvs");
        //cn.ConnectionString = "Integrated Security=true;Initial Catalog=NetAuction;Data Source=.";
        cn.ConnectionString = "Data Source=DESKTOP-9V6EBK0;Initial Catalog=NetAuction;Integrated Security=True";
        if (!IsPostBack)
        {
            for (int i = 2; i <= 10; i++)
            {
                DropDownList1.Items.Add(i.ToString());
            }
            data();
        }
    }
    public void data()
    {
        string s = Session["user"].ToString();
        cmd = new SqlCommand("select custid from newuser where uid='" + s + "'", cn);
        cn.Open();
        dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            TextBox1.Text = dr[0].ToString();
        }
        dr.Close();
        cn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text == "")
        {
            Label1.Visible = true;
            Label1.Text = "Must Enter Item Name";
        }
        else if (TextBox3.Text == "")
        {
            Label1.Visible = true;
            Label1.Text = "Must Enter Intial Cost";
        }
        else if (TextBox4.Text == "")
        {
            Label1.Visible = true;
            Label1.Text = "Must Enter Increment Cost";
        }
        else if (TextBox5.Text == "")
        {
            Label1.Visible = true;
            Label1.Text = "Must Enter Item Desc";
        }
        else if (TextBox2.Text == "")
        {
            Label1.Visible = true;
            Label1.Text = "Must Enter Item Name";
        }
        else if (DropDownList1.SelectedItem.Text == "----Select----")
        {
            Label1.Visible = true;
            Label1.Text = "Must Select No. Of Days";
        }
        else
        {
            Label1.Visible = false;
            string s = "sealed";
            string date = DateTime.Now.ToString();
            da = new SqlDataAdapter("insert item values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "'," + DropDownList1.SelectedItem.Text + ",'" + s + "','" + date + "')", cn);
            da.Fill(ds);
            Response.Write("<script>alert('Values are Inserted')</script>");
            clear();
            data();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        clear();
        data();
    }
    public void clear()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        DropDownList1.SelectedIndex = -1;
    }

}
