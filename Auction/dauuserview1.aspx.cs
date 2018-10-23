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
    public partial class dauuserview1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["user"].ToString();
            cn.ConnectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";
            if (btnSearch == null)
            {
                da = new SqlDataAdapter("select * from item where type='dutch'", cn);
            }
            else
            {
                string name = txtSearch.Text;
                da = new SqlDataAdapter("select * from item where type='dutch' and itemname like '%" + name + "%'", cn);
            }
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}