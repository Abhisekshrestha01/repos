using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            bool status1 = true;
            bool status2 = true;
            int d1 = 0;
            int s1 = 0;
            int f1 = 0;
            int f2 = 0;
            
            
            do
            {
                Console.WriteLine("Enter the valid first number:");
                status1 = int.TryParse(Console.ReadLine(), out f1);
            } while (status1 == false);
            do
            {
                Console.WriteLine("Enter the valid second number:");
                status2 = int.TryParse(Console.ReadLine(), out f2);
            } while (status2 == false);
            Console.WriteLine("The value parameter example is :" + Sum(f1,f2));
            Console.WriteLine("The reference parameter example is :" + Sum1( ref f1, ref f2));
            Sumdif(f1, f2, out s1, out d1);
            Console.WriteLine("The output parameter example is : sum "+ s1 +"and diff"+d1);
            


        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sum1(ref int a, ref int b)
        {
            return a + b;
        }
        public static void Sumdif(int a, int b, out int s1, out int d1)
            {
                s1 = a+b;
                d1 = a-b;

            }

        
    }
}
