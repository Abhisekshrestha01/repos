using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for(int i=1;i<3;i++)
            {
                foreach (int x in a)
                {
                    if (x == 3)
                    {
                        continue;
                    }
                    Console.WriteLine(x);
                    if (x == 5)
                    {
                        break;
                    }
                    Console.WriteLine(x);
                }
            }
            
        }
    }
}
