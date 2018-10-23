using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLink;

namespace practice_1
{
    public partial class edit : System.Web.UI.Page
    {
        Database db = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["username"] == null)
            {
                Response.Redirect("LogIn.aspx");
            }
            else
            {

                string name = Session["username"].ToString();
                

                DataSet ds = new DataSet();
                int id = int.Parse(Request.QueryString["ID"]);
                ds = db.GetDetailEdit(id);
                DataRow dr = ds.Tables[0].Rows[0];
                string name1 = dr["Name"].ToString();
                string gender = dr["Gender"].ToString();
                string email = dr["Email"].ToString();
                string age = dr["Age"].ToString();
                string filelocation = dr["FileLocation"].ToString();
                
                if (!IsPostBack)
                {
                    txtname.Text = name1;
                    txtemail.Text = email;
                    txtage.Text = age;
                }
                Image1.ImageUrl = filelocation;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                
                string name = Session["username"].ToString();
                db.Editdata(txtname.Text, RadioButtonList1.SelectedValue, txtemail.Text, txtage.Text, name);
                    Response.Redirect("Home.aspx");
                
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtemail.Text = "";
            txtage.Text = "";
           
        }
    }
}