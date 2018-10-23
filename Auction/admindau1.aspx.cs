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
    public partial class admindau1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;

        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            //cn.ConnectionString = System.Configuration.ConfigurationManager.AppSettings.Get("gvs");
            //cn.ConnectionString = "Integrated Security=true;Initial Catalog=NetAuction;Data Source=.";
            cn.ConnectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";

            grid();
        }
        public void grid()
        {
            if (btnSearch == null)
            {
                da = new SqlDataAdapter("select * from item where type='dutch'", cn);
            }
            else
            {
                string name = txtSearch.Text;
                da = new SqlDataAdapter("select * from item where type='dutch' and itemname like '%" + name + "%'", cn);
            }
            ds = new DataSet();
            da.Fill(ds);
            GridView123.DataSource = ds.Tables[0];
            GridView123.DataBind();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView123.PageIndex = e.NewPageIndex;
            grid();
        }
    }
}