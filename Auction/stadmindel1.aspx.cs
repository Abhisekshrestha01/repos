﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Auction
{
    public partial class stadmindel1 : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd;
        SqlDataReader dr;

        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            //cn.ConnectionString = System.Configuration.ConfigurationManager.AppSettings.Get("gvs");
            //cn.ConnectionString = "Integrated Security=true;Initial Catalog=NetAuction;Data Source=.";
            cn.ConnectionString = @"Data Source=DESKTOP-0Q267P3\SQLEXPRESS;Initial Catalog=NetAuction;Integrated Security=True";
            if (!IsPostBack)
            {
                data();
                grid();
            }
        }
        public void grid()
        {
            da = new SqlDataAdapter("select * from item where type='straight'", cn);
            ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        public void data()
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("----Select----");
            cmd = new SqlCommand("select itemid from item where type='straight'", cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            cn.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "----Select----")
            {
                Label2.Visible = true;
                Label2.Text = "Must Select Item Id";
            }
            else
            {
                da = new SqlDataAdapter("delete from item where itemid=" + DropDownList1.SelectedItem.Text + "", cn);
                ds = new DataSet();
                da.Fill(ds);
                Response.Write("<script>alert('Recored is Deleted')</script>");
                grid();
            }
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            grid();
        }
    }
}