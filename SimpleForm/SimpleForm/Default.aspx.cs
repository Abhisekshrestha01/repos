using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

namespace SimpleForm
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CountriesData"] == null)
            {
                Country C1 = new Country()
                {
                    Code = "AUS",
                    Name = "Australia",
                    Capital = "Canberra"
                };
                Country C2 = new Country()
                {
                    Code = "IND",
                    Name = "India",
                    Capital = "NewDelhi"
                };
                Country C3 = new Country()
                {
                    Code = "USA",
                    Name = "United States",
                    Capital = "WashingtonDC"
                };

                List<Country> countrylist = new List<Country>();
                countrylist.Add(C1);
                countrylist.Add(C2);
                countrylist.Add(C3);

                Dictionary<string, Country> dict = countrylist.ToDictionary(x => x.Code, x => x);

                Session["CountriesData"] = dict;
            }


        }

        protected void txttcountrycode_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, Country> dictionary = (Dictionary<string, Country>)Session["CountriesData"];
            Country C5 = dictionary.ContainsKey(txttcountrycode.Text.ToUpper()) ? dictionary[txttcountrycode.Text.ToUpper()] : null;
            if (C5 == null)
            {
                Label1.Text = "Enter a valid country code";
                txtname.Text = "";
                txtcapital.Text = "";
            }
            else
            {
                txtname.Text = C5.Name;
                txtcapital.Text = C5.Capital;
            }

        }
    }
}