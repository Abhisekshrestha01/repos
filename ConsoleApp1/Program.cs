using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 1;
            while (Num != 0)
            {
                int x, y;
                getnumber(x,y);
                int sum = x + y;
                Console.WriteLine("The sum is " + sum);

            }
        }
            public static void getnumber(int a, int b)
            {
                Console.Write("Enter the first number :");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("Enter the second number :");
                b = Int32.Parse(Console.ReadLine());
            
            }
        
        
    }
}
