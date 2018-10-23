using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the operation of the calculator: + for sum, - for sub, / for duvusion and * for multiplication");
            string operation = Console.ReadLine();
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            switch(operation)
            {
                case "+":
                    Console.WriteLine("The sum of {0} and {1} is {2}",num1,num2,num2+num2);
                    break;
                case "-":
                    Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, num2 - num2);
                    break;
                case "/":
                    Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, num2 / num2);
                    break;
                case "*":
                    Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, num2 * num2);
                    break;
            }
            Console.ReadLine();

        }
    }
}
