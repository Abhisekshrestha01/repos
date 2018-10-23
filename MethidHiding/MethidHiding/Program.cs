using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethidHiding
{
    public class Employee
    {
        public string firstname;
        public string lastname;
        

        public void PrintFullName()
        {
            Console.WriteLine(firstname + " " + lastname);
        }
        
    }
    public class PartTimeEmploye : Employee
    {
        public new void PrintFullName()
        {
            
            Console.WriteLine(firstname + " " + lastname + "- contractor");
        }
    }
    public class FullTimeEmploye : Employee
    {

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmploye FTE = new FullTimeEmploye();
            FTE.firstname = "Abhisek";
            FTE.lastname = "Shrestha";
            FTE.PrintFullName();

            Employee PTE = new PartTimeEmploye();
            PTE.firstname = "Part";
            PTE.lastname = "Time";
            PTE.PrintFullName();
        }
    }
}
