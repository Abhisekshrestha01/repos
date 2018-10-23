using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadCityDropDownList();
            }
        }
        public void LoadCityDropDownList()
        {
            ListItem li1 = new ListItem("Hongkong");
            DropDownList1.Items.Add(li1);
            ListItem li2 = new ListItem("Delhi");
            DropDownList1.Items.Add(li2);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("Index value changed");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {

        }
    }
}