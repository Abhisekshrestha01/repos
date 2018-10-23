using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter the character to replace the whitespace");
            string string2 = Console.ReadLine();
            string value = null;
           // string rvalue = string1;
            //    char[] string123 = string1.ToCharArray();
            //Array.Reverse(string123);
            foreach(var str in string1)
            {
                if(str==' ')
                {
                    value += string2;
                }
                else
                {
                    value += str;
                }

            }
            Console.WriteLine("The replaced string is : " + value);
        }
        
    }
}
