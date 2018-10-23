using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Application["click"] == null)
                {
                    Application["click"] = 0;
                }

                TextBox1.Text = Application["click"].ToString();
            }

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(Application["click"]) + 1;
            TextBox1.Text = count.ToString();
            Application["click"] = count;



        }
    }
}