using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using DatabaseLink;

namespace practice_1
{
    public partial class Defaults : System.Web.UI.Page
    {
        Database db = new Database();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtname.Focus();
            if (!IsPostBack)
            {
                ListBox1.Visible = false;
                DropDownList1.DataSource = db.Getdata("spGetContinents", null);

                DropDownList1.DataBind();

                ListItem liContinent = new ListItem("Select Continent", "-1");
                DropDownList1.Items.Insert(0, liContinent);

                DropDownList2.Enabled = false;
                DropDownList3.Enabled = false;
               
            }

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder strtemp = new StringBuilder();
            foreach (ListItem m in CheckBoxList1.Items)
            {
                if (m.Selected) { strtemp.Append(m.Value+", "); }

            }
            
            if (FileUpload1.HasFile)
            {
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (fileExtension.ToLower() != ".jpg" && fileExtension.ToLower() != ".jpeg")
                {
                    Label7.Text = "Only file with .jpg or .jpeg extension is allowed";
                    Label7.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    int filesize = FileUpload1.PostedFile.ContentLength;
                    if (filesize > 2097152)
                    {
                        Label7.Text = "Maximum file size 2MB is exceeded";
                        Label7.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/Uploads/" + FileUpload1.FileName));
                        Label7.Text = "File Uploaded";
                        Label7.ForeColor = System.Drawing.Color.Red;
                    }

                }

            }
            else
            {
                Label7.Text = "Please select a file";
                Label7.ForeColor = System.Drawing.Color.Red;
            }
            
            if (IsValid)
            {
                if (db.CheckUserName(txtusername.Text))
                {

                    string filelocation = "Uploads/" + FileUpload1.FileName;
                    db.Insertdata(txtname.Text, RadioButtonList1.SelectedValue, txtemail.Text, strtemp.ToString(), DropDownList1.SelectedValue, DropDownList2.SelectedValue, DropDownList3.SelectedValue, filelocation, txtage.Text, txtpassword.Text, txtusername.Text);
                    Response.Redirect("LogIn.aspx");
                }
                else
                {

                    Label8.Text = txtusername.Text + " already exists. Please Enter another one";
                }
            }
        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtemail.Text = "";
            txtage.Text = "";
            txtpassword.Text = "";
            txtrepassword.Text = "";
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {

            }
            else
            {

                DropDownList2.Enabled = true;
                SqlParameter parameter = new SqlParameter("@ContinentId", DropDownList1.SelectedItem.Value);
                DataSet DS = db.Getdata("spGetCountriesByContinentId", parameter);
                DropDownList2.DataSource = DS;

                DropDownList2.DataBind();
                ListItem liCountry = new ListItem("Select Country", "-1");
                DropDownList2.Items.Insert(0, liCountry);

            }

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList2.SelectedIndex == 0)
            {

            }
            else
            {

                DropDownList3.Enabled = true;
                SqlParameter parameter = new SqlParameter("@CountryId", DropDownList2.SelectedItem.Value);
                DataSet DS = db.Getdata("spGetCitiesByCountryId", parameter);
                DropDownList3.DataSource = DS;

                DropDownList3.DataBind();
                ListItem liCity = new ListItem("Select City", "-1");
                DropDownList3.Items.Insert(0, liCity);

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            foreach (ListItem m in CheckBoxList1.Items)
            {
                m.Selected = true;
            }



        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            ListBox1.Visible = true;
            ListBox1.Items.Clear();
            foreach (ListItem m in CheckBoxList1.Items)
            {
                if (m.Selected)
                {
                    ListItem checklist = new ListItem(m.Text, m.Value);
                    ListBox1.Items.Add(checklist.Text);
                    count++;
                }
            }

        }
    }
}