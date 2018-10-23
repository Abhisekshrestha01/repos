using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dummy
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtFirstName.Text = "Please enter name";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            ddlRole.SelectedIndex = 0;
            txtPassword.Text = "";
        }

        protected void ddlRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSignupLogin_Click(object sender, EventArgs e)
        {
            // Logic to check user authentication
            Session["User"] = txtSignupName.Text.Trim();
            Response.Redirect("Userinformation.aspx");
        }

        protected void btnSignupCancel_Click(object sender, EventArgs e)
        {
            txtSignUpPassword.Text = "";
            txtSignupName.Text = "";
        }
    }
}