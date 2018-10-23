using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcase = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<testcase; i++)
            {
                int num =  Convert.ToInt32(Console.ReadLine());
                string str = Console.ReadLine();
                string[] arrstring = str.Split(' ');
                int[] arrint = new int[num-1];
                for(int j=0; j<num; j++)
                {
                    arrint[j] = Convert.ToInt32(arrstring[j]);
                }

            }
        }
    }
}
