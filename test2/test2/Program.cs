using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the numerator");
                int numerator;
                bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out numerator);
                if (IsNumeratorConversionSuccessful)
                {
                    Console.WriteLine("Enter the denumerator");
                    int denumerator;
                    bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out denumerator);

                        if (IsDenominatorConversionSuccessful && denumerator != 0)
                    {
                        int Result = numerator / denumerator;

                        Console.WriteLine("The result is " + Result);
                    }
                    else
                    {
                        if (denumerator == 0)
                        {
                            Console.WriteLine("Please enter number other than 0");
                        }
                        else
                        {
                            Console.WriteLine("Entered number should be a valid number between {0} && {1}  ", Int32.MinValue, Int32.MaxValue);
                        }
                    }


                }
                else
                {
                    Console.WriteLine("Entered number should be a valid number between {0} && {1}  ", Int32.MinValue, Int32.MaxValue);
                }




            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
