using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDisplayname.Models
{
    public class Company
    {
        public Employee CompanyDirector
        {
            get
            {
                EmployeeContext employeEContext = new EmployeeContext();
                return employeEContext.Employees.Single(n => n.Id == 1);
            }
        }
    }
}