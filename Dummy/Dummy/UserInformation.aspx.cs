using System;
using System.Data;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dummy
{
    public partial class UserInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["User"] != null)
                {
                    BindUserGrid(Session["User"].ToString().ToLower());
                }
                else
                {
                    Response.Redirect("default.aspx");
                }
            }
        }

        private void BindUserGrid(string name)
        {
            var xDoc = new XmlDocument();
            xDoc.Load(Server.MapPath("cd_catalog.xml"));

            XmlNodeList xList = xDoc.SelectNodes("CATALOG/CD");
            
            var dt = new DataTable();
            dt.Columns.Add("TITLE");
            dt.Columns.Add("ARTIST");
            dt.Columns.Add("COUNTRY");
            dt.Columns.Add("COMPANY");
            dt.Columns.Add("PRICE");
            dt.Columns.Add("YEAR");


            DataRow dr = dt.NewRow();
           
            switch (name)
            {
                case "vicky":
                    {                       
                        dr["TITLE"] = "Dev";
                        dr["ARTIST"] = "Vicky";
                        dr["COUNTRY"] = "INDIA";
                        dr["COMPANY"] = "PSL";
                        dr["PRICE"] = 100.50;
                        dr["YEAR"] = 2000;
                        dt.Rows.Add(dr);

                        foreach(XmlNode xNode in xList)
                        {
                            DataRow dr1 = dt.NewRow();
                            dr1["TITLE"] = xNode["TITLE"].InnerText;
                            dr1["ARTIST"] = xNode["ARTIST"].InnerText;
                            dr1["COUNTRY"] = xNode["COUNTRY"].InnerText;
                            dr1["COMPANY"] = xNode["COMPANY"].InnerText;
                            dr1["PRICE"] =Convert.ToDouble(xNode["PRICE"].InnerText);
                            dr1["YEAR"] =Convert.ToInt16(xNode["YEAR"].InnerText);
                            dt.Rows.Add(dr1);
                        }
                      
                        break;
                    }
                case "team":
                    {
                        dr["TITLE"] = ".NET";
                        dr["ARTIST"] = "TEAM";
                        dr["COUNTRY"] = "USA";
                        dr["COMPANY"] = "IMCS";
                        dr["PRICE"] = 100.50;
                        dr["YEAR"] = 2000;
                        dt.Rows.Add(dr);

                        foreach (XmlNode xNode in xList)
                        {
                            DataRow dr1 = dt.NewRow();
                            dr1["TITLE"] = xNode["TITLE"].InnerText;
                            dr1["ARTIST"] = xNode["ARTIST"].InnerText;
                            dr1["COUNTRY"] = xNode["COUNTRY"].InnerText;
                            dr1["COMPANY"] = xNode["COMPANY"].InnerText;
                            dr1["PRICE"] = Convert.ToDouble(xNode["PRICE"].InnerText);
                            dr1["YEAR"] = Convert.ToInt16(xNode["YEAR"].InnerText);
                            dt.Rows.Add(dr1);
                        }
                        break;
                    }
                default:
                    dr["TITLE"] = "Sales";
                    dr["ARTIST"] = "RYAN";
                    dr["COUNTRY"] = "USA";
                    dr["COMPANY"] = "IMCS";
                    dr["PRICE"] = 100.50;
                    dr["YEAR"] = 2000;
                    dt.Rows.Add(dr);

                    foreach (XmlNode xNode in xList)
                    {
                        DataRow dr1 = dt.NewRow();
                        dr1["TITLE"] = xNode["TITLE"].InnerText;
                        dr1["ARTIST"] = xNode["ARTIST"].InnerText;
                        dr1["COUNTRY"] = xNode["COUNTRY"].InnerText;
                        dr1["COMPANY"] = xNode["COMPANY"].InnerText;
                        dr1["PRICE"] = Convert.ToDouble(xNode["PRICE"].InnerText);
                        dr1["YEAR"] = Convert.ToInt16(xNode["YEAR"].InnerText);
                        dt.Rows.Add(dr1);
                    }
                    break;
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;

            if (Session["User"] != null)
            {
                BindUserGrid(Session["User"].ToString().ToLower());
            }
            else
            {
                Response.Redirect("default.aspx");
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}