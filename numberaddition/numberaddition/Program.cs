using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberaddition
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Enter any two digit number");
            int i = Convert.ToInt32(Console.ReadLine());
            int i1 = i % 10;
            int i2 = i / 10;
            total = i1 + i2;
            Console.WriteLine(total);
        }
        
    }
}
