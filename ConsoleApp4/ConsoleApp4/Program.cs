using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            DropDownEntities2 context = new DropDownEntities2();
            IEnumerable<tblDepartment> departments = context.tblDepartments.Where(n => n.Name == "IT" || n.Name == "HR");

            foreach(tblDepartment dept in departments)
            {
                Console.WriteLine(dept.Name);
                IEnumerable<tblStudent> students = context.tblStudents.Where(n => n.Gender == "Male");
                foreach(tblStudent a in students)
                {
                    Console.WriteLine("Name = " + a.FirstName + " " + a.LastName);
                }
                Console.WriteLine();
            }
        }
    }
}
