using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringlist = new List<string>();
            for(int a = 0;a<5;a++)
            {
                Console.WriteLine("Enter the strings");
                string name = Console.ReadLine();
                 
                stringlist.Add(name);
            }
            foreach(var v in stringlist)
            {
                Console.WriteLine(v);
            }

        }
        
    }
}
