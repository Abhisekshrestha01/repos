using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auction
{
    public partial class adminsearesult11: System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommand cmd1;
        SqlDataReader dr1;

        string amount;

        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            cn.ConnectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";

            if (!IsPostBack)
            {
                data();
            }
            da = new SqlDataAdapter("select * from buyer where Itemid='" + Request.QueryString["ID"].ToString() + "'", cn);
            ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();

            cmd = new SqlCommand("select max(amount) from buyer where itemid=" + Request.QueryString["ID"].ToString() + "", cn);
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
        public void data()
        {
            cmd = new SqlCommand("select itemid from item where type='sealed'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Request.QueryString["ID"].Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }
        

        
            
        
        private DateTime GetBidFinishDateTimeOfItem(int itemId)
        {
            da = new SqlDataAdapter(" select cdate,noofdays from dbo.item where itemid='" + itemId + "'", cn);
            DataTable dt = new DataTable();
            cn.Open();
            da.Fill(dt);
            cn.Close();
            DateTime date = Convert.ToDateTime(dt.Rows[0][0]);
            int noOfDays = Convert.ToInt32(dt.Rows[0][1]);
            DateTime bidFinishdate = date.AddDays(noOfDays);

            return bidFinishdate;
        }
        public void result()
        {
            dr.Close();
            cmd1 = new SqlCommand("select * from buyer where amount=" + amount + " and itemid=" + Request.QueryString["ID"].ToString() + "", cn);

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
            da = new SqlDataAdapter("select * from buyer where Itemid='" + Request.QueryString["ID"].ToString() + "'", cn);
            ds = new DataSet();
            da.Fill(ds);
            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            int itemId = Convert.ToInt32(Request.QueryString["ID"].ToString());
            if (currentDateTime >= GetBidFinishDateTimeOfItem(itemId))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Info", "alert('Successfully result stored');", true);
                string s = "winner";
                string a = "sealed";
                string query1 = "select uname from dbo.newuser where custid = " + TextBox3.Text;
                da = new SqlDataAdapter(query1, cn);
                DataTable dt1 = new DataTable();
                da.Fill(dt1);
                string uname = dt1.Rows[0][0].ToString();
                da = new SqlDataAdapter("insert result values(" + TextBox1.Text + ",'" + TextBox2.Text + "'," + TextBox3.Text + ",'" + TextBox4.Text + "','" + s + "','" + a + "','1','"+ uname +"')", cn);
                ds = new DataSet();
                da.Fill(ds);
                //Mail(Convert.ToInt32(TextBox3.Text));
                int id = Convert.ToInt32(TextBox3.Text);
                string item = TextBox2.Text;
                int amount = Convert.ToInt32(TextBox4.Text);
                string query = "select emailid, uname from dbo.newuser where custid = " + id;
                da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string email = dt.Rows[0][0].ToString();
                string name = dt.Rows[0][1].ToString();
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("abhisek.shrestha1991@gmail.com");
                mail.To.Add(email);
                mail.Subject = "You are Winner";
                mail.Body = "Hello " + name + ",\n You won the Sealed Auction for item " + item + " at price $" + amount + ".\n Please contact the seller abhisek.shrestha1991@gmail.com \n\nWith Regards,\n Online Auction System \n Lamar University";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("abhisek.shrestha1991@gmail.com", "exercise01");
                SmtpServer.EnableSsl = true;


                try
                {
                    SmtpServer.Send(mail);
                    Response.Write("<script>alert('Successfully Sent...');if(alert){ window.location='SendMail.aspx';}</script>");
                }
                catch (Exception ex)
                {
                    Exception ex2 = ex;
                    string errorMessage = string.Empty;
                    Response.Write("<script>alert('Sending Failed...');if(alert){ window.location='SendMail.aspx';}</script>");
                }
                Response.Redirect("adminsearesult11.aspx?ID=" + Request.QueryString["ID"].ToString());
                //Response.Write("<script>alert('Values are Submitted')</script>");

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Info", "alert('Bid going on');", true);
            }
            
            
        }
        
        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}