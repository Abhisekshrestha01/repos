using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            EmployeeDBcontext employeeDBcontext = new EmployeeDBcontext();
            return employeeDBcontext.Departments.Include("Employees").ToList();
        }
    }
}