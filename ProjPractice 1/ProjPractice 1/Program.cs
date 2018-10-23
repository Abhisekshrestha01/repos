using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPractice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write names before sorting");
            List<stud> studentList = stud.GetAllStudents();
            foreach(var s1 in studentList)
            {
                Console.WriteLine(s1.Name);
            }
            //IEnumerable<stud> student = stud.GetAllStudents().OrderByDescending(n => n.Name).Reverse();
            IEnumerable<stud> student = from student1 in stud.GetAllStudents()
                                        orderby student1.Name
                                        select student1;
            Console.WriteLine("After the sorting");
            foreach (var s1 in student)
            {
                Console.WriteLine(s1.Name);
            }
        }
    }
}
