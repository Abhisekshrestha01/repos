using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class SesssionStateOne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["click"] == null)
                {
                    Session["click"] = 0;
                }

                TextBox1.Text = Session["click"].ToString();
            }

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Session["click"]) + 1;
            TextBox1.Text = count.ToString();
            Session["click"] = count;



        }
    }
}