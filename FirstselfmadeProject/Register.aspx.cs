using FirstselfmadeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstselfmadeProject
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Users us = new Users(txtname.Text, txtusername.Text, txtpassword.Text, txtemail.Text, Convert.ToDateTime(txtdob.Text));
            us.Save();
        }

        protected void grdUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}