using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using DatabaseLink;
using XMLLink;

namespace practice_1
{
    public partial class Home : System.Web.UI.Page
    {
        int ID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }
            else
            {
                string name = Session["username"].ToString();
                if (name == "admin")
                {
                    Button2.Visible = false;
                    Image1.Visible = false;
                    Label8.Text = "Here are the list of Flights with Details:";
                }
                else
                {
                    Button3.Visible = false;
                    Label8.Text = "Here are the list of Flights:";
                    
                }
                
                Label1.Text = "Hello " + name + ". Here are details :";
                Database db = new Database();
                string filelocation = db.Getlocation(name);
                Image1.ImageUrl = filelocation;
                DataSet ds = new DataSet();
                if (name == "admin")
                {
                    ds = db.GetDetailAll();
                }
                else
                {
                    ds = db.GetDetail(name);
                }
                    
                
                DataRow dr = ds.Tables[0].Rows[0];
                ID = (int)dr["ID"];

                GridView1.DataSource = ds;
                GridView1.DataBind();

                DataSet ds1 = new DataSet();
                if (!IsPostBack)
                {
                    BindData1();
                }
                



            }
        }
        public void BindData1()
        {
            XMLhelper xml = new XMLhelper();
            DataSet ds1 = new DataSet();
            ds1 = xml.ShowXMLFIleData();
            if (ds1.Tables.Count == 0)
            {
                GridView2.Visible = false;

            }
            else
            {
                GridView2.DataSource = ds1;
                GridView2.DataBind();
                
                if (Session["username"].ToString() == "admin")
                {
                    GridView2.Columns[2].Visible = true;
                }
                else
                {
                    GridView2.Columns[2].Visible = false;
                }
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("LogIn.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit.aspx?ID=" + ID);
        }
        protected void Detail_Click(object sender, EventArgs e)
        {

            
            if ( "admin" == Session["username"].ToString())
            {
                Label10.Text = "Here are the details:";
                string flightId = ((sender as LinkButton).CommandArgument);
                XMLhelper xml = new XMLhelper();
                XmlNode Node = xml.GetselectedData(flightId);
                DataTable dt = new DataTable();
                dt.Columns.Add("Flight no");
                dt.Columns.Add("Departure City");
                dt.Columns.Add("Departure Date");
                dt.Columns.Add("Arrival City");
                dt.Columns.Add("Arrival Time");
                dt.Columns.Add("No Of Seats");
                
                    dt.Rows.Add(Node["flightno"].InnerText.ToString(),
                                   Node["DepartureCity"].InnerText.ToString(),
                                   Node["DepartureDate"].InnerText.ToString(),
                                   Node["ArrivalCity"].InnerText.ToString(),
                                   Node["ArrivalTime"].InnerText.ToString(),
                                   Node["NoOfSeats"].InnerText.ToString()
                                  );
                    GridView3.DataSource = dt;
                    GridView3.DataBind();
                    

                    
                
            }
            else
            {
                Label10.Text = "You are not authorized to access the details";
                Label10.ForeColor = System.Drawing.Color.Red;
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Fight_registration.aspx");
        }

        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            

        }
    }
}