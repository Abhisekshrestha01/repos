using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag1 = true;
            bool flag2 = true;
            int fnum = 0;
            int snum = 0;

            do
            {
                Console.WriteLine("Enter the valid First Number between 10000 and -10000 :");
                flag1 = int.TryParse(Console.ReadLine(), out fnum);
            } while ((flag1 == false) || (fnum < -10000) || (fnum > 10000));
            do
            {
                Console.WriteLine("Enter the valid Second Number between 10000 and -10000 :");
                flag2 = int.TryParse(Console.ReadLine(), out snum);
                if (fnum >= snum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("First number is greater then second number");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while ((flag2 == false) || (snum < -10000) || (snum > 10000) || (snum <= fnum));
            if ((fnum < 0) && (snum < 0))
            {
                Console.WriteLine(0);
            }
            else
            {
                if (fnum <= 0)
                {
                    fnum = 0;
                }
                if (snum <= 0)
                {
                    snum = 0;
                }
                int temp1 = (int)Math.Ceiling(Math.Sqrt(fnum));
                //Console.WriteLine(temp1);
                int temp2 = (int)Math.Floor(Math.Sqrt(snum));
                //Console.WriteLine(temp2);
                int value = temp2 - temp1 + 1;
                Console.WriteLine(value);
            }

        }
    }
}
