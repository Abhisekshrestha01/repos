using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, count = 0, rel;
            double sqNum, rel2;
            validation valA = new validation();
            Num1 = valA.validateNumber();
            Console.WriteLine("Number A entered is : " + Num1);
            Num2 = valA.validateNumberB(Num1);
            Console.WriteLine("Number B entered is : " + Num2);
            Stopwatch ExecTimer = new Stopwatch();
            ExecTimer.Start();
            if (Num1 >= 0 && Num2 >= 0)
            {
                count = 0;
                for (int i = Num1; i <= Num2; i++)
                {

                    sqNum = Math.Sqrt(i);
                    rel = Convert.ToInt32(sqNum);
                    rel2 = Convert.ToDouble(rel);
                    if (sqNum % rel2 == 0)
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine("The number of perfect squares in this interval is : " + count);
            }
            else if (Num1 <= 0 && Num2 >= 0)
            {
                count = 0;
                for (int i = 0; i <= Num2; i++)
                {
                    sqNum = Math.Sqrt(i);
                    rel = Convert.ToInt32(sqNum);
                    rel2 = Convert.ToDouble(rel);
                    if (sqNum % rel2 == 0)
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine("The number of perfect squares in this interval is : " + count);
            }
            else if (Num1 <= 0 && Num2 <= 0)
            {
                count = 0;
                Console.WriteLine("Negative numbers are not perfect squares.");
            }
            else
            {
                Console.WriteLine("Impossible!!");
            }
            ExecTimer.Stop();
            Console.WriteLine("The time taken for code to run : " + ExecTimer.ElapsedMilliseconds);
            Console.ReadKey();

        }
    }
    class validation
    { 
    public int validateNumber()
    {
        string StrA;
        int NumA = 0;
        do
        {
            Console.WriteLine("Please enter a number between -10000 to 10000");
            StrA = Console.ReadLine();

        } while (!int.TryParse(StrA, out NumA));
        NumA = Convert.ToInt32(StrA);
        if (NumA >= -10000 && NumA <= 10000)
        {

            return NumA;
        }

        return validateNumber();
    }
        public int validateNumberB(int Number)
        {
            string StrA;
            int NumA = 0;
            do
            {
                Console.WriteLine("Please enter a number between -10000 to 10000");
                StrA = Console.ReadLine();

            } while (!int.TryParse(StrA, out NumA));
            NumA = Convert.ToInt32(StrA);
            if (NumA >= -10000 && NumA <= 10000)
            {
                if (NumA >= Number)
                {

                    return NumA;
                }
                else
                {
                    Console.WriteLine("Number B cannot be lesser than Number A\n\n");
                }
            }

            return validateNumberB(Number);
        }
    }
}
