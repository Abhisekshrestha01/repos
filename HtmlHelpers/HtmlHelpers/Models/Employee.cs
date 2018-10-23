using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HtmlHelpers.Models
{
    public class Employee
    {
        private string _name;
        public Employee (string name)
        {
            this._name = name;
        }
        public string SelectedDepartment { get; set; }
        public List<Department> GetDepartment
        {
            get
            {
                EmployeesContext employeEContext = new EmployeesContext();
                return employeEContext.Departments.ToList();
            }
        }
        public string CompanyName
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }
        }
        
    }
}