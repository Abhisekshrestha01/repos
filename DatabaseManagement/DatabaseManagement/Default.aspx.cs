using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace DatabaseManagement
{
    public partial class _Default : Page
    {
        string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand();
                    //cmd.CommandText = " update tblProduct set UnitPrice='2476' where ProductId=5; ";
                    cmd.CommandText = " select * from tblProduct;";
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    GridView1.DataSource = sdr;
                    GridView1.DataBind();

                    //Using scalar value database
                    //int count = Convert.ToInt32(cmd.ExecuteScalar());
                    //Response.Write(count);

                    //Inserting value in the database
                    //int TotalRowsEffected = cmd.ExecuteNonQuery();
                    //Response.Write("Total rows effected is" + TotalRowsEffected);
                }


            }
        }

        protected void Btnsearch_Click(object sender, EventArgs e)
        {
            string searchitem = txtsearch.Text;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from tblProduct where Name like @ProductName";
                cmd.Parameters.AddWithValue("@ProductName", txtsearch.Text +"%");
                con.Open();
                SqlDataReader adr = cmd.ExecuteReader();
                GridView1.DataSource = adr;
                GridView1.DataBind();
            }
                

        }
    }
}