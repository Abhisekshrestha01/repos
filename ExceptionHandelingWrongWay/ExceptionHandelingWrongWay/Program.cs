using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingWrongWay
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
                int a = 0;
                Console.WriteLine("Enter the first number:");
                bool x = int.TryParse(Console.ReadLine(), out a);
                if (x)
                {
                    int b = a + 1;
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine("Number should be a valid number between {0} && {1}", Int32.MinValue, Int32.MaxValue);
                }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please enter a number");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


        }
    }
}
