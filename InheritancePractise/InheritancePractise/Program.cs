using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractise
{
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public Employee(){
            Console.WriteLine("Parent Class");    
        }
        public void PrintFullName()
        {
            Console.WriteLine("The full name is : {0} {1}", this.firstName, this.lastName);

        }

    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;

        public FullTimeEmployee()
        {
            Console.WriteLine("Child Class");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "Abhisek";
            FTE.lastName = "Shrestha";
            FTE.YearlySalary = 500000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "Part";
            PTE.lastName = "Time";
            PTE.HourlyRate = 20000;
            PTE.PrintFullName();
        }
    }
}
