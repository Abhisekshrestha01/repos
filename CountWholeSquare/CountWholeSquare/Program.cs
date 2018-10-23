using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculation;

namespace CountWholeSquare
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


            Calculate calculate = new Calculate();
            int count = 0;
            List<int> lst = new List<int>();
            Stopwatch st = new Stopwatch();
            st.Start();
            calculate.Countwholesquare(fnum, snum, out count, out lst);
            st.Stop();
            //var time = st.ElapsedMilliseconds;
            Console.WriteLine("Time take to execute the code: "+ st.ElapsedMilliseconds+"ms");
            Console.Write("The Count of Whole Square between");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[{0},{1}] ", fnum, snum);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(both included) is : ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(count);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("The list of the numbers are:");
            foreach (int x in lst)
            {
                Console.WriteLine("Square of : " + Math.Sqrt(x) +" is:"+x);
            }
            Console.ReadKey();
            

        }
    }
}
