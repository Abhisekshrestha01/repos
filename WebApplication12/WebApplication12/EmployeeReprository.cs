using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication12
{
    public class EmployeeReprository
    {
        public List<Department> GetDepartments()
        {
            EmployeeDBcontext employeeDBContext = new EmployeeDBcontext();
            return employeeDBContext.Department.Include("Employees").ToList();
        }
    }
}