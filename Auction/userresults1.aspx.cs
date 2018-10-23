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
    public partial class userresults1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = Session["user"].ToString();
            cn.ConnectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";
            if (IsPostBack == false)
            {
                LoadDataOnDropDown();
            }
          
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Label1.Text = "straight Auction Winner";
            da = new SqlDataAdapter("select * from result where type='straight'", cn);
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Label1.Text = "dutch Auction Winner";
            da = new SqlDataAdapter("select * from result where type='dutch'", cn);
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

        private void LoadDataOnDropDown()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("select distinct itemid , itemname from dbo.result where type like 'dutch' ", cn);
            DataTable dt = new DataTable();
            cn.Open();
            sqlDa.Fill(dt);
            cn.Close();
            //DropDownList1.DataTextField = "itemname";
            //DropDownList1.DataValueField = "itemid";
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(DropDownList1.Text);
            string query = "select * from dbo.result where itemId='" + itemId + "'";
            SqlDataAdapter sqlDa = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            cn.Open();
            sqlDa.Fill(dt);
            cn.Close();
            
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
    }
}