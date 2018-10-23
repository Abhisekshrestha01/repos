using Auction.Logic;
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
    public partial class admindauresult1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;
        SqlCommand cmd1;
        SqlDataReader dr1;

        string amount;

        SqlDataAdapter da;
        DataSet ds;
        List<dutchBid> listdutchBid = new List<dutchBid>();
        string connectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";
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
            cmd = new SqlCommand("select itemid from item where type='dutch'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //Request.QueryString["ID"].Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }
        
        
           
       
        public void result()
        {
            dr.Close();
            cmd1 = new SqlCommand("select * from buyer where amount='" + amount + "' and itemid='" + Request.QueryString["ID"].ToString() + "'", cn);

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

        private DateTime GetBidFinishDateTimeOfItem(int itemId)
        {
            da = new SqlDataAdapter(" select cdate,noofdays from dbo.item where itemid='" + itemId+"'", cn);
            DataTable dt = new DataTable();
            cn.Open();
            da.Fill(dt);
            cn.Close();
            DateTime date=Convert.ToDateTime( dt.Rows[0][0]);
            int noOfDays= Convert.ToInt32(dt.Rows[0][1]);
            DateTime bidFinishdate=date.AddDays(noOfDays);

            return bidFinishdate;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            int itemId = Convert.ToInt32(Request.QueryString["ID"].ToString());
            if (currentDateTime >= GetBidFinishDateTimeOfItem(itemId))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Info", "alert('Successfully result stored');", true);

                ComputeBid();

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
                mail.Body = "Hello " + name + ",\n You won the dutch Auction for item " + item + " at price $" + amount + ".\n Please contact the seller abhisek.shrestha1991@gmail.com \n\n With Regards, \n Online Auction System \n Lamar University";

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
                Response.Redirect("admindauresult1.aspx?ID=" + Request.QueryString["ID"].ToString());

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Info", "alert('Bid going on');", true);
            }

           
           /* string s = "winner";
            string a = "dutch";
            da = new SqlDataAdapter("insert result values(" + TextBox1.Text + ",'" + TextBox2.Text + "'," + TextBox3.Text + ",'" + TextBox4.Text + "','" + s + "','" + a + "')", cn);
            ds = new DataSet();
            da.Fill(ds);
            Response.Write("<script>alert('Values are Submited')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            */
        }

        private void ComputeBid()
        {
            try
            {
                int itemId=Convert.ToInt32(Request.QueryString["ID"].ToString());
                string query = " select dbo.buyer.itemname, dbo.buyer.custname, dbo.buyer.itemid,dbo.buyer.custid,dbo.buyer.amount,dbo.buyer.qty as 'bQty',dbo.item.qty as 'aQty', dbo.item.cdate from dbo.buyer inner join dbo.item  on dbo.buyer.itemid=dbo.item.itemid where dbo.buyer.[type] = 'dutch'  and dbo.buyer.custid in (select custId from buyer where Itemid='"+ itemId+ "') and dbo.item.itemid='" + itemId + "' group by dbo.buyer.itemname, dbo.buyer.itemid,dbo.buyer.custid, dbo.buyer.custname, dbo.buyer.amount,dbo.buyer.qty, dbo.item.qty , dbo.item.cdate order by amount desc";
                using (SqlConnection c = new SqlConnection(connectionString))
                {
                    c.Open();
                    // 2
                    // Create new DataAdapter
                    using (SqlDataAdapter a = new SqlDataAdapter(query, c))
                    {
                        // 3
                        // Use DataAdapter to fill DataTable
                        DataTable t = new DataTable();
                        a.Fill(t);
                        
                        for (int i = 0; i < t.Rows.Count; i++)
                        {
                            dutchBid bid = new dutchBid();
                            bid.itemname = t.Rows[i]["itemname"].ToString();
                            bid.custname = t.Rows[i]["custname"].ToString();
                            bid.itemid = Convert.ToInt32(t.Rows[i]["itemid"]);
                            bid.custid = Convert.ToInt32(t.Rows[i]["custid"]);
                            bid.amount = Convert.ToInt32(t.Rows[i]["amount"]);
                            bid.bidQty = Convert.ToInt32(t.Rows[i]["bQty"]);
                            bid.avaliableQty = Convert.ToInt32(t.Rows[i]["aQty"]);
                            bid.bidFinishDate = Convert.ToDateTime(t.Rows[i]["cdate"]);
                            listdutchBid.Add(bid);
                        }
                        

                        // 4
                        // Render data onto the screen
                        // dataGridView1.DataSource = t; // <-- From your designer
                    }

                }
                IEnumerable<IGrouping<string, dutchBid>> groupings = listdutchBid.GroupBy(x => x.itemname);
                foreach (var bids in groupings)
                {
                    string itemName = bids.Key;
                    int avaliableQty = bids.FirstOrDefault().avaliableQty;
                    int totalNumberOfQuantity = bids.Sum(x => x.bidQty);
                    if (totalNumberOfQuantity < avaliableQty)
                    {
                        //
                        double minimumAmount = bids.Min(x => x.amount);
                        //insert 
                        string type = "dutch";
                        InsertBidResult(bids);

                    }
                    else
                    {
                        //
                        List<dutchBid> list = new List<dutchBid>();
                        int totalQuantity = bids.FirstOrDefault().avaliableQty;
                        int remainingQty = totalQuantity;
                        bool flag = true;
                        foreach (dutchBid dutchBid in bids)
                        {
                            int bidQty = dutchBid.bidQty;
                            if (remainingQty > 0)
                            {
                                dutchBid dBid = new dutchBid()
                                {

                                    amount = dutchBid.amount,
                                    avaliableQty = dutchBid.avaliableQty,
                                    bidFinishDate = dutchBid.bidFinishDate,
                                    bidQty = dutchBid.bidQty,
                                    custid = dutchBid.custid,
                                    itemid = dutchBid.itemid,
                                    custname = dutchBid.custname,
                                    itemname = dutchBid.itemname

                                };
                                list.Add(dBid);

                                if (!WinningGroup(remainingQty, bidQty))
                                {
                                    flag = false;
                                }

                            }
                            remainingQty = remainingQty - bidQty;

                        }
                        if (remainingQty < 0)
                        {
                            flag = false;
                        }

                        if (flag)
                        {
                            InsertBidResult(bids);
                        }
                        else
                        {
                            decimal factor = Convert.ToDecimal(totalQuantity) / list.Sum(x => x.bidQty);
                            double minimumAmount = bids.Min(x => x.amount);
                            string type = "dutch";
                            foreach (var bid in list)
                            {
                                decimal tempBid = bid.bidQty * factor;
                                bid.bidQty = Convert.ToInt32(Decimal.Round(tempBid));
                                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                                {
                                    string insertQuery = @"INSERT INTO [dbo].[result](
                                 [itemid], [itemname],  [custid], [amount],  [result],  [type],qty,[custname]  ) 

                                 VALUES('" + bid.itemid + "','" + bid.itemname + "','" + bid.custid + "','" + minimumAmount + "','" + type + "','" + type + "','"+bid.bidQty+"','"+ bid.custname +"')";

                                    SqlCommand sqlCmd = new SqlCommand(insertQuery, sqlCon);
                                    sqlCon.Open();
                                    sqlCmd.ExecuteNonQuery();
                                }
                            }
                        }



                    }

                }


            }
            catch (Exception ex)
            {

            }
        }

        private bool WinningGroup(int remQty, int aQty)
        {
            if (aQty <= remQty)
            {
                return true;
            }
            return false;
        }

        private void InsertBidResult(IGrouping<string, dutchBid> bids)
        {
            string type = "dutch";
            double minimumAmount = bids.Min(x => x.amount);
            foreach (var bid in bids)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    string insertQuery = @"INSERT INTO [dbo].[result](
                                 [itemid], [itemname],  [custid], [amount],  [result],  [type],qty,[custname]  ) 

                                 VALUES('" + bid.itemid + "','" + bid.itemname + "','" + bid.custid + "','" + minimumAmount + "','" + type + "','" + type + "','" + bid.bidQty + "','" + bid.custname + "')";

                    SqlCommand sqlCmd = new SqlCommand(insertQuery, sqlCon);
                    sqlCon.Open();
                    sqlCmd.ExecuteNonQuery();
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
                    mail.Body = "Hello " + name + ", You won the dutch Auction for item " + item + " at price " + amount + ". Please contact the seller.";

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
                }
            }
        }
       
    }
}