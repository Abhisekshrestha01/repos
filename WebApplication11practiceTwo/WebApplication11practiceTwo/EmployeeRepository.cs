using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11practiceTwo
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            EmployeeDBcontext employeeDBContext = new EmployeeDBcontext();
            return employeeDBContext.Departments.ToList();
        }
    }
}