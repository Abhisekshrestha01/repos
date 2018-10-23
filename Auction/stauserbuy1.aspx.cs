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
    public partial class stauserbuy1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;

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
            cmd = new SqlCommand("select * from item where type='straight' and Itemid='" + Request.QueryString["ID"].ToString() + "'", cn);
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
            da = new SqlDataAdapter("select * from item where type='straight' and Itemid='" + Request.QueryString["ID"].ToString() + "'", cn);
            ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

            buyer();
        }
        public void data()
        {
            cmd = new SqlCommand("select itemid from item where type='straight'", cn);
            cn.Open();
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
            da = new SqlDataAdapter("select * from buyer where type='straight' and itemid='" + Request.QueryString["ID"].ToString() + "'", cn);
            ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
        }
        protected void GridView2_PageIndexChanged(object sender, EventArgs e)
        {
            //GridView2.
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString();
            string a = "straight";
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
            Response.Redirect("stauserbuy1.aspx?ID="+ Request.QueryString["ID"].ToString());


        }
        public void clear()
        {

        }
        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            buyer();
        }
    }
}