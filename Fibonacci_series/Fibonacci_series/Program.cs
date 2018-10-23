using System;

namespace Fibonacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter the number of Fibonacci Series you want to print:");
            num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num);
            //int a = 0;
            //int b = 1;
            //for(int i=0;i<num;i++)
            //{
            //    Console.WriteLine(a);
            //    int sum = a + b;
            //    a = b;
            //    b = sum;
            //}

            Calculate_fibonaciiSeries(num-1, 0, 1);
        }

        public static void Calculate_fibonaciiSeries(int range, int first, int second)
        {
            Console.WriteLine(first);
            int sum = first + second;
            if(range!=0)
            {

                Calculate_fibonaciiSeries(range-1, second, sum);
            }
        }
    }
}
