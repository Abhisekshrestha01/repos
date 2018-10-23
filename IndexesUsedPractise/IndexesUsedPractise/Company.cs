using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndexesUsedPractise
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
    }
    public class Company
    {
        private List<Employee> listEmployee;
        public Company()
        {
            listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployee.Add(new Employee() { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployee.Add(new Employee() { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployee.Add(new Employee() { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployee.Add(new Employee() { EmployeeId = 5, Name = "Emiliy", Gender = "female" });
            listEmployee.Add(new Employee() { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployee.Add(new Employee() { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployee.Add(new Employee() { EmployeeId = 8, Name = "Ben", Gender = "Male" });
        }
         
        public string this[int employeeId]
        {
            get
            {
                return listEmployee.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }

            set
            {
                listEmployee.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }
    }
}