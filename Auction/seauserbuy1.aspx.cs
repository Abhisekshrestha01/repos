using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auction
{
    public partial class seauserbuy1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataReader dr;
        SqlDataReader dr1;

        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label7.Text = Session["user"].ToString();
            cn.ConnectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";
            if (!IsPostBack)
            {
                data();
            }
            fill();
            cmd = new SqlCommand("select * from item where type='sealed' and Itemid='" + Request.QueryString["ID"].ToString() + "'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox1.Text = dr[1].ToString();
                TextBox2.Text = dr[2].ToString();
                //TextBox3.Text = dr[0].ToString();
                //TextBox4.Text = dr[0].ToString();
            }
            dr.Close();
            cn.Close();
            da = new SqlDataAdapter("select * from item where type='sealed' and Itemid='" + Request.QueryString["ID"].ToString() + "'", cn);
            ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

            buyer();
        }
        string user;
        public void data()
        {

            string s = Session["user"].ToString();
            cmd1 = new SqlCommand("select * from newuser where uid='" + s + "'", cn);
            cn.Open();
            dr1 = cmd1.ExecuteReader();

            if (dr1.Read())
            {
                user = dr1[0].ToString();
            }
            dr1.Close();

            cmd = new SqlCommand("select itemid from item where type='sealed'", cn);
            //cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Request.QueryString["ID"].Add(dr[0].ToString()); 
            }
            dr.Close();
            cn.Close();
        }
       
            

        public void fill()
        {
            string s = Session["user"].ToString();
            cmd = new SqlCommand("select custid from newuser where uid='" + s + "'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox3.Text = dr[0].ToString();

            }
            dr.Close();
            cn.Close();
        }
        public void buyer()
        {
            da = new SqlDataAdapter("select * from buyer where type='sealed' and Itemid='" + Request.QueryString["ID"].ToString() + "'", cn);
            ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString();
            string a = "sealed";
            string query1 = "select uname from dbo.newuser where custid = " + TextBox3.Text;
            da = new SqlDataAdapter(query1, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string uname = dt.Rows[0][0].ToString();
            da = new SqlDataAdapter("insert buyer values(" + TextBox1.Text + ",'" + TextBox2.Text + "'," + TextBox3.Text + ",'" + s + "'," + TextBox4.Text + ",'" + a + "','1','"+ uname +"')", cn);
            ds = new DataSet();
            da.Fill(ds);
            Response.Write("<script>alert('Values Are Posted')</script>");
            buyer();
            TextBox4.Text = "";
            Response.Redirect("seauserbuy1.aspx?ID=" + Request.QueryString["ID"].ToString());
        }
        protected void GridView2_PageIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            buyer();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            da = new SqlDataAdapter("select * from item where type='sealed' and Itemid='" + Request.QueryString["ID"].ToString() + "'", cn);
            ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
    }
}