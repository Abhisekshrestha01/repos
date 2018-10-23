using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndSave
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    class Company
    {
        private List<Employee> emp;
        public Company()
        {
            emp = new List<Employee>();
            emp.Add(new Employee { Name = "Mark", Age = 24, Address = "Dallas" });
            emp.Add(new Employee { Name = "Many", Age = 29, Address = "Dallas" });
        }
        public int this[string employeeName]
        {
            get
            {
                return emp.FirstOrDefault(x => x.Name == employeeName).Age ;
            }
            set
            {
                emp.FirstOrDefault(x => x.Name == employeeName).Age = value;
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company com = new Company();
            Console.WriteLine("Age of employee of name Mark : "+com["Mark"]);
            com["Many"] = 24;
            Console.WriteLine("Age of employee of name Many : "+com["Many"]);
        }
    }
}
