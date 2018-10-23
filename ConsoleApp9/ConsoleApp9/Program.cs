using System;
using System.Linq;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = new int[] { 0, 1, 2, 3, 5, 6, 7, 8, 9 };
            check(intarray);
        }
        public static void check(int[] arrayvalue)
        {
            
            for(int i=0; i<10;i++)
            {
                if(!arrayvalue.Contains(i))
                {
                    Console.WriteLine("The missing number is : "+ i);
                    Console.ReadLine();
                }
            }
        }
    }
}
