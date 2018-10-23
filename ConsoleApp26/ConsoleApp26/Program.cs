using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Employee : IComparable<Employee>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee other)
        {
            if (this.ID > other.ID)
                return 1;
            else if (this.ID < other.ID)
                return -1;
            else
                return 0;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee() {ID='1', Name="asdf" };
            Employee E2 = new Employee() {ID='2', Name="hjkl" };
            List<Employee> emplist = new List<Employee>();
            emplist.Add(E1);
            emplist.Add(E2);
            emplist.Sort();
            foreach(var lst in emplist)
            {
                Console.WriteLine(lst.ID+" "+lst.Name);
            }
            
        }
    }

    
}
