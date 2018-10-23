using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupprac
{
    class Program
    {
        static void Main(string[] args)
        {
            var employmentByDepartment = Department.GetAllDepartments()
               .GroupJoin(Employee.GetAllEmployees(),
               d => d.ID,
               e => e.DepartmentID,
               (department, employee) => new
               {
                   Department = department,
                   Employee = employee
               });
            foreach(var department in employmentByDepartment)
            {
                Console.WriteLine(department.Department.Name);
                foreach(var employee in department.Employee)
                {
                    Console.WriteLine(" " + employee.Name);
                }
                Console.WriteLine();
            }
        }
    }
}
