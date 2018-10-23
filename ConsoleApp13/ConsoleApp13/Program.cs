using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter a String");
            string s = Console.ReadLine();
            string rs = Reverse(s);
            if(s == rs)
            {
                Console.WriteLine("The string is palindrome");
            }                
            else
            {
                Console.WriteLine("The string is not a palindrome");
            }

            Console.ReadLine();
            */
            while(true)
            {
                Console.WriteLine("Enter the numbers:");
                int[] a = new int[5] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };
                //foreach( int b in a)
                //    {
                //    Console.WriteLine(b);
                //}
                List<int> oddlist = new List<int>();
                List<int> evenlist = new List<int>();
                for(int i = 0; i<=4; i++)

                {
                    if (a[i] % 2 == 0)
                        evenlist.Add(a[i]);
                    else
                        oddlist.Add(a[i]);
                }
                Console.WriteLine("The even list is:");
                foreach (int a1 in evenlist)
                {
                    Console.WriteLine(a1);
                }
                Console.WriteLine("The odd list is : ");
                foreach (int b1 in oddlist)
                {
                    Console.WriteLine(b1);
                }
            }

           
            
           


        }
        
        /*
        public static String Reverse (string a)
        {
            string t = string.Empty;
            Char[] arr = a.ToCharArray();    
            for(int i = arr.Length-1;i>-1;i--)
            {
                t = t + arr[i];
            }
            return t;
        }
        */


    }
}
