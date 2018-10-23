using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirstsplitEF
{
    public class EmployeeRepository
    {
        EmployeeDBcontext employeeDBcontext = new EmployeeDBcontext();

        public List<Employee> GetEmployees()
        {
            return employeeDBcontext.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            employeeDBcontext.Employees.Add(employee);
            employeeDBcontext.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            Employee employeeToUpdate = employeeDBcontext.Employees
                .SingleOrDefault(x => x.EmployeeId == employee.EmployeeId);
            employeeToUpdate.EmployeeId = employee.EmployeeId;
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.Gender = employee.Gender;
            employeeToUpdate.Email = employee.Email;
            employeeToUpdate.Mobile = employee.Mobile;
            employeeToUpdate.Landline = employee.Landline;

            employeeDBcontext.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            Employee employeeToDelete = employeeDBcontext.Employees
                .SingleOrDefault(x => x.EmployeeId == employee.EmployeeId);
            employeeDBcontext.Employees.Remove(employeeToDelete);
            employeeDBcontext.SaveChanges();
        }
    }
}