using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 15; i++) {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBUzz");
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
