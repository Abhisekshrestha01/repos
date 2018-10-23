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
    public partial class seausersell1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string path;

        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Text = Session["user"].ToString();
            cn.ConnectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";
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
                FileUpload1.SaveAs(Request.PhysicalApplicationPath + "/itemImage/" + FileUpload1.FileName.ToString());
                path = "itemimage/" + FileUpload1.FileName.ToString();
                string date = DateTime.Now.ToString();
                da = new SqlDataAdapter("insert into item(custid,  itemname, initialcost, incrementcost, itemdesc, noofdays, type, cdate,qty,Image_path) values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "'," + DropDownList1.SelectedItem.Text + ",'" + s + "','" + date + "',1,'" + path.ToString() + "')", cn);
                da.Fill(ds);
                Response.Write("<script>alert('Values are Inserted')</script>");
                //string sql = "insert into item(custid, itemid, itemname, initialcost, incrementcost, itemdesc, noofdays, type, cdate) values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "'," + DropDownList1.SelectedItem.Text + ",'" + s + "','" + date + "')";
                //cn.Open();
                //SqlCommand sqlCmd = new SqlCommand(sql, cn);

                //sqlCmd.ExecuteNonQuery();
                //cn.Close();
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
}