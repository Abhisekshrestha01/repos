using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();
            
            string[] x = str.Split('$');
            var index2 = x.Count() > 2 ? x[0].Length + x[1].Length + 1 : 0;
            var index3 = x.Count() > 3 ? x[0].Length + x[1].Length + x[2].Length + 1 : 0;

            Console.WriteLine(a);
        }
    }
}
