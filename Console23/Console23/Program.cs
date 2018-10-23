using System;
using System.Text;

namespace Console23
{
    class Program
    {
        static void Main(string[] args)
        {
            // reverse the array


            /*int[] arrint = new int[] { 10, 20, 30 };
             int[] temp = new int[3];
             for (int i = 0, j = temp.Length-1;i<= arrint.Length-1;i++,j--)
             {
                 temp[j] = arrint[i];

             }
             Console.Write("{");
             foreach(int v in temp)
             {
                 Console.Write(v);
                 Console.Write(", ");
             }
             Console.Write("}");
             Console.ReadLine();
     */

            // rcalculation of numbers:


            /*string operation = null;
            while(operation!="exit")
            {
                Console.WriteLine("Enter First number");
                Double firstnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                Double secondnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter either SUM, SUB, MUL, DIV or exit to exit from the system");
                operation = Console.ReadLine();
                switch (operation.ToLower())
                {
                    case "sum":
                        Console.WriteLine("The sum is : " + sum(firstnumber, secondnumber));
                        break;
                    case "sub":
                        Console.WriteLine("The substraction is : " + sub(firstnumber, secondnumber));
                        break;
                    case "mul":
                        Console.WriteLine("The multiplication is : " + mul(firstnumber, secondnumber));
                        break;
                    case "div":
                        Console.WriteLine("The Division is : " + div(firstnumber, secondnumber));
                        break;
                    case "exit":
               
                            break;
                    default:
                        Console.WriteLine("Enter the valid operation");
                            break;
                }
            }
           */
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int reserve = number;
            int r = 0;
            int n = 0;
            while(number>0)
            {
                r = number % 10;
                n = n * 10 + r;
                number = number / 10;
            }
            if(reserve == n)
            {
                Console.WriteLine("The number is palindrame");
            }
            else
            {
                Console.WriteLine("The number is not a palindrame");
            }
            Console.ReadLine();
        }
        /*
        public static double sum(double a, double b)
        {
            return a + b;
        }
        public static double sub(double a, double b)
        {
            return a - b;
        }
        public static double mul(double a, double b)
        {
            return a * b;
        }
        public static double div(double a, double b)
        {
            if(b!=0)
            {
                return a / b;
            }
            return 0;
        }
            
    */
        
            
    
        
    }
}
