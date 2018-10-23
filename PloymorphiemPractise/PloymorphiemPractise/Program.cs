using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloymorphiemPractise
{
    public class Empolyee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Empolyee
    {
        public override void PrintFullName()
        {
            
                Console.WriteLine(FirstName + " " + LastName + " - Part Time");
            
        }

    }
    public class FullTimeEmployee : Empolyee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Fill Time");
        }

    }
    public class TemporaryEmployee : Empolyee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Temporary");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Empolyee[] E = new Empolyee[4];
            E[0] = new Empolyee();
            E[1] = new PartTimeEmployee();
            E[2] = new FullTimeEmployee();
            E[3] = new TemporaryEmployee();

            foreach(Empolyee e in E)
            {
                e.PrintFullName();
            }
        }
    }
}
