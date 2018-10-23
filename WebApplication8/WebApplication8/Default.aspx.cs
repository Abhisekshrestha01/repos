using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

using System.Data;
namespace WebApplication8
{
    public partial class _Default : Page
    {
        string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd;



            if (!IsPostBack)
            {
                cmd = new SqlCommand("select * from tbl_Gender", con);

                cmd.Connection = con;


                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DropDownList1.DataSource = sdr;

                    DropDownList1.DataValueField = "Gid";
                    DropDownList1.DataTextField = "Gender";
                    DropDownList1.DataBind();
                    con.Close();
                
            }
            cmd = new SqlCommand("select * from details", con);

            cmd.Connection = con;
            con.Open();
            using(SqlDataReader sdr1 = cmd.ExecuteReader())
                {
                DataTable table1 = new DataTable();
                table1.Columns.Add("Id");
                table1.Columns.Add("Name");
                table1.Columns.Add("Salary");
                table1.Columns.Add("DiscountedSalary");

                while(sdr1.Read())
                {
                    DataRow dataRow = table1.NewRow();
                    int OriginalSalary = Convert.ToInt32(sdr1["Salary"]);
                    double DiscountedSalary = OriginalSalary * 0.9;
                    dataRow["ID"] = sdr1["Id"];
                    dataRow["Name"] = sdr1["Name"];
                    dataRow["Salary"] = OriginalSalary;
                    dataRow["DiscountedSalary"] = DiscountedSalary;
                    table1.Rows.Add(dataRow);

                }
                GridView1.DataSource = table1;
                GridView1.DataBind();

            }
            con.Close();





        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spInsertValueInTable", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Gender", DropDownList1.SelectedValue);
                cmd.Parameters.AddWithValue("@Sly", txtsalary.Text);

                SqlParameter outputParameter = new SqlParameter();
                outputParameter.ParameterName = "@Idinserted";
                outputParameter.SqlDbType = System.Data.SqlDbType.Int;
                outputParameter.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParameter);

                con.Open();
                cmd.ExecuteNonQuery();

                string NameId = outputParameter.Value.ToString();

               
            }
        }
    }
}
