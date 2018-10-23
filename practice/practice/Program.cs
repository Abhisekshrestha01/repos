using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    public class Employee : IComparable<Employee>
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double Salary { set; get; }
        // string Type { set; get; }

        public int CompareTo(Employee emp)
        {
            if (this.Salary > emp.Salary)
                return 1;
            else if (this.Salary < emp.Salary)
                return -1;
            else
                return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter three strings :");
            //string s1 = Console.ReadLine();

            //string s2 = Console.ReadLine();

            //string s3 = Console.ReadLine();

            //List<String> stringL = new List<string>();
            //stringL.Add(s1);
            //stringL.Add(s2);
            //stringL.Add(s3);

            //stringL.Sort();

            //Console.WriteLine("The sorted strings are:");
            //foreach(var str in stringL)
            //{
            //    Console.WriteLine(str);
                
            //}

            //Console.WriteLine("The desc strings are:");
            //stringL.Reverse();
            //foreach (var str in stringL)
            //{
            //    Console.WriteLine(str);

            //}
            Employee E1 = new Employee()
            {
                Id = 1,
                Name = "Mark",
                Salary = 10000
               //Type = "Retail" 


            };
        Employee E2 = new Employee()
        {
            Id = 2,
            Name = "John",
            Salary = 15000
            //Type = "Retail"


        };

            
    Employee E3 = new Employee()
    {
        Id = 3,
        Name = "May",
        Salary = 20000
        //Type = "Corporate"


            };

            //Employee E4 = new Employee()
            //{
            //    Id = 4,
            //    Name = "June",
            //    Salary = 25000,
            //    Type = "Corporate"



            //};
            //Employee[] empArray = new Employee[2];
            List<Employee> EmplistRetail = new List<Employee>();
            EmplistRetail.Add(E1);
            EmplistRetail.Add(E2);
            EmplistRetail.Add(E3);
            //EmplistRetail.Add(E4);

            //EmplistRetail.AddRange(EmplistCorporate);

            //EmplistRetail.RemoveAll(emp => emp.Type == "Corporate");


            //foreach(var emp in EmplistRetail)
            //{
            //    Console.WriteLine(emp.Name);
            //}

            //int index = empList.FindLastIndex(emp => emp.Salary > 12000);
            //Console.WriteLine(index);


            //List<Employee> findValue = empList.FindAll(emp => emp.Salary > 12000);
            //foreach(var Emp in findValue)
            //{
            //    Console.WriteLine(Emp.Name);
            //}

            //Employee Emp = empList.FindLast(emp => emp.Salary > 12000);
            //Console.WriteLine(Emp.Name);

            //if(empList.Exists(x=>x.Name.StartsWith("M")))
            //    {
            //    Console.WriteLine("Employee exists");
            //}
            //else
            //{
            //    Console.WriteLine("E1 abscent");
            //}


            //Dictionary<int, Employee> dict = empList.ToDictionary(emp => emp.Id, emp => emp);



            //foreach(var k in dict)
            //{
            //    Employee emp1 = k.Value;

            //        Console.WriteLine(emp1.Id + " " + emp1.Name + " " + emp1.Salary);
            //        Console.ReadLine();

            //}


        }
    }
}
