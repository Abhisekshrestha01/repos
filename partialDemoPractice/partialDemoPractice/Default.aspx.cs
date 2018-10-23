using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace partialDemoPractice
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer C1 = new Customer();
            C1.FirstName = "FN";
            C1.LastName = "LN";
            string FullName1 = C1.Print();
            Response.Write("Full Name = " + FullName1 + "<br/>");

            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = "FN";
            C2.LastName = "L";
            string FullName2 = C2.Print();
            Response.Write(FullName2 + "<br/>");


        }
    }
}