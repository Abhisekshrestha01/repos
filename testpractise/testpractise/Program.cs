using System;
using System.Collections.Generic;


namespace testpractise
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            employee.Add(new Employee() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5 });
            employee.Add(new Employee() { Id = 102, Name = "Mike", Salary = 4000, Experience = 4 });
            employee.Add(new Employee() { Id = 103, Name = "John", Salary = 6000, Experience = 6 });
            employee.Add(new Employee() { Id = 104, Name = "Todd", Salary = 3000, Experience = 3 });

            

            Employee.PromoteEmployee(employee, x => x.Experience > 5);


        }
        
    }
    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //    public int Experience { get; set; }

    //    public static void PromoteEmployee(List<Employee> employeeList)
    //    {
    //        foreach (Employee employee in employeeList)
    //        {
    //            if(employee.Experience >=5)
    //            {
    //                Console.WriteLine(employee.Name + "promoted");
    //            }
    //        }
    //    }
    //}
    delegate Boolean IsPromote(Employee empl);
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List<Employee> employeeList, IsPromote IsEligible)
        {
            foreach (Employee employee in employeeList)
            {
                if(IsEligible(employee))
                {
                    Console.WriteLine(employee.Name + "promote");
                }
            }

        }
    }
}
