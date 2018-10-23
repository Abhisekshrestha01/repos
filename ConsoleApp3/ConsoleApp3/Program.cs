using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> liststring = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> evenlist = from n in liststring
                                        where n % 2 == 0
                                        select n;
            //IEnumerable<int> evenlist = liststring.Where(n => n % 2 == 0);
            foreach(int a in evenlist)
            {
                Console.WriteLine(a);
            }
        }
    }
}
