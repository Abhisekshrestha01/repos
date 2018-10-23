using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDataContext db = new EmployeeDataContext();
            var result = db.details.AsEnumerable().Where(n => n.Salary > 14000);

            foreach(var i in result)
            {
                Console.WriteLine(i.Name + " " + i.Salary );
            }

        }
    }
}
