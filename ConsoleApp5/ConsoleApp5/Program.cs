using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = Student.GetAllStudetns().ToDictionary(n => n.StudentID, n => n.Name);

            foreach( KeyValuePair<int, string> S1 in dict)
            {
                Console.WriteLine(S1.Key+" " +  S1.Value  );
            }
            
        }
    }
}