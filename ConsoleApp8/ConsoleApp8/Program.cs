using System;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string");
            string string1 = System.Console.ReadLine();
            if(DoesRepeat(string1))
            {
                Console.WriteLine("It has repeated character");
            }
            else
            {
                Console.WriteLine("It does not have repeated character");
            }
            
        }
        public static Boolean DoesRepeat(string str)
        {
            int x = str.Distinct().Count();
            if(x == str.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
