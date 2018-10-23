using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoopsAndConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            bool flag = true;
            double result = 0;
            int num = 0;
            string operation = null;
            List<double> lstresult = new List<double>();
            List<double> flst = new List<double>();
            List<double> lastlst = new List<double>();
            List<string> slst = new List<string>();
            //   -------------------------------Use of While loop------------------------
            while(true)
            {
                //------------------------------Use of do while loop--------------------------
                do
                {
                    //----------------------------Use of if condition--------------------
                    if (operation == null)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Calculate the result and find if it is a prime number");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (operation!=null)
                    {
                        if((operation != "+") && (operation != "-") && (operation != "/") && (operation != "*"))
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("PLease enter a valid operator");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    Console.WriteLine("Enter the Operation: \"+\" for sum, \"-\" for sub, \"/\" for div, \"*\" for mul, \"X\" for exit");
                    operation = Console.ReadLine();
                } while ((operation != "+") && (operation != "-") && (operation != "/") && (operation != "*") && (operation != "x") && (operation != "X"));
                if (operation == "x" || operation == "X")
                {
                    Console.WriteLine("You are Exiting from the system. You List of results are");
                    Thread.Sleep(1000);
                    break;
                }
                do
                {
                    if (flag == false)
                    {
                       
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter an integer");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    Console.WriteLine("Enter the First number: ");
                    flag = double.TryParse(Console.ReadLine(), out num1);
                } while (!flag);
                do
                {
                    if (flag == false)
                    {
                       
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter an integer");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    Console.WriteLine("Enter the Secondnumber: ");
                    flag = double.TryParse(Console.ReadLine(), out num2);
                    if ((operation=="/")&&(num2 == 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("the denominator cannot be 0");
                        Console.ForegroundColor = ConsoleColor.White;

                        flag = false;
                    }
                } while (!flag);
                //--------------------------------------Use of switch-----------------------
                switch (operation)
                {
                    case "+":
                        result = Sum(num1, num2);
                        Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, result);
                        break;

                    case "-":
                        result = Sub(num1, num2);
                        Console.WriteLine("The sub of {0} and {1} is {2}", num1, num2, result);
                        break;

                    case "/":
                        result = Div(num1, num2);
                        Console.WriteLine("The div of {0} and {1} is {2}", num1, num2, result);
                        //-------------------Use of Break----------------------------
                        break;

                    case "*":
                        result = Mul(num1, num2);
                        Console.WriteLine("The mul of {0} and {1} is {2}", num1, num2, result);
                        break;
                }
                lstresult.Add(result);
                flst.Add(num1);
                lastlst.Add(num2);

                slst.Add(operation);

                num = Convert.ToInt32(result);
                Console.ForegroundColor = ConsoleColor.Red;

                //-------------------------------explicite type conversion------------------
                Console.WriteLine("The explicite conversion of {0}(double) to int is {1}", result, num);
                Console.ForegroundColor = ConsoleColor.White;

                //----------------------------use of ternary operator----------------------------------
                Console.WriteLine("The Result {0} is" + (Isprime(num) ? " a Prime number" : "not a Prime number"), num);
                Console.WriteLine("");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your history is:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{");
            
            for(int i=0; i < lstresult.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Histroy {0} : '" +flst[i]+""+slst[i]+" "+lastlst[i]+" ' = ' "+lstresult[i]+"'",i+1 );
                Console.ForegroundColor = ConsoleColor.White;
            }
            //foreach(double x in lstresult)
            //{
            //    if (x == lstresult[lstresult.Count - 1])
            //    {
            //        Console.Write(x + " ");
            //    }
            //    else
            //    {
            //        Console.Write(x + ", ");
            //    }
                
                
                
            //}
            Console.Write("}");
                   
        }

        public static double Sum(double a, double b)
        {
            return a + b;

        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Div(double a, double b)
        {
                return a / b;
        }
        public static double Mul(double a, double b)
        {
            return a * b;
        }
        public static Boolean Isprime(int a)
        {
            bool prime = true;
            if (a == 0)
            {
                prime = false;
            }
            //---------------------------------Use of for loop-----------------------------
            for (int i=2;i<=a/2;i++)
            {
                if (a % i == 0) 
                    {
                        prime = false;
                    }
                
            }
                return prime;
            }
    }
}
