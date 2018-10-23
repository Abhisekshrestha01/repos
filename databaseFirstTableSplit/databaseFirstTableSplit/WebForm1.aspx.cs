using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Entity;

namespace databaseFirstTableSplit
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(CheckBox1.Checked)
            {
                GridView1.DataSource = getEmployeeDataIncludingContactDetails();
            }
            else
            {
                GridView1.DataSource = getEmployeeData();
            }
            GridView1.DataBind();
        }
        private DataTable getEmployeeDataIncludingContactDetails()
        {
            EmployeeEntities employeeDBContext = new EmployeeEntities();
            List<Employee> employees = employeeDBContext.Employees.Include("EmployeeContact").ToList();

            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("EmployeeID"),
                                 new DataColumn("FirstName"),
                                 new DataColumn("LastName"),
                                 new DataColumn("Gender"),
                                 new DataColumn("Email"),
                                 new DataColumn("Mobile"),
                                 new DataColumn("LandLine") };
            dataTable.Columns.AddRange(columns);

            foreach (Employee employee in employees)
            {
                DataRow dr = dataTable.NewRow();
                dr["EmployeeID"] = employee.EmployeeID;
                dr["FirstName"] = employee.FirstName;
                dr["LastName"] = employee.LastName;
                dr["Gender"] = employee.Gender;
                dr["Email"] = employee.EmployeeContact.Email;
                dr["Mobile"] = employee.EmployeeContact.Mobile;
                dr["LandLine"] = employee.EmployeeContact.LandLine;

                dataTable.Rows.Add(dr);
            }
            return dataTable;

        }
        private DataTable getEmployeeData()
        {
            EmployeeEntities employeeDBContext = new EmployeeEntities();
            List<Employee> employees = employeeDBContext.Employees.ToList();

            DataTable dataTable = new DataTable();
            DataColumn[] columns = { new DataColumn("EmployeeID"),
                                 new DataColumn("FirstName"),
                                 new DataColumn("LastName"),
                                 new DataColumn("Gender")};
            dataTable.Columns.AddRange(columns);

            foreach (Employee employee in employees)
            {
                DataRow dr = dataTable.NewRow();
                dr["EmployeeID"] = employee.EmployeeID;
                dr["FirstName"] = employee.FirstName;
                dr["LastName"] = employee.LastName;
                dr["Gender"] = employee.Gender;
                

                dataTable.Rows.Add(dr);
            }
            return dataTable;

        }
    }
}