using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15
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
            Employee employeeToUpdate = employeeDBcontext.Employees.FirstOrDefault( n => n.ID ==employee.ID);
            employeeToUpdate.Name = employee.Name;
            employeeToUpdate.Gender = employee.Gender;
            employeeToUpdate.Salary = employee.Salary;
            employeeDBcontext.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            Employee employeeToDelete = employeeDBcontext.Employees.FirstOrDefault(n => n.ID == employee.ID);
            employeeDBcontext.Employees.Remove(employeeToDelete);
            
            employeeDBcontext.SaveChanges();
        }
    }
}