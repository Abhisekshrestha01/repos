using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseLink;

namespace practice_1
{
    public partial class LogIn : System.Web.UI.Page
    {
        Database ds = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(ds.LoginCheck(txtusername.Text, txtpassword.Text))
            {
                Session["username"] = txtusername.Text;
                
                    Response.Redirect("Home.aspx");
                
               
            }
            else
            {
                LabelloginIssue.Text = "Username Or Password is Incorrect";
            }

        }
    }
}