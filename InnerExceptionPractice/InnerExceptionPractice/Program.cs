using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InnerExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the First number :");
                    int FirstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second number :");
                    int SecondNumber = Convert.ToInt32(Console.ReadLine());
                    int Result = FirstNumber / SecondNumber;
                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Users\shres\Desktop\Data1.txt";
                    if (File.Exists(filePath))
                    {

                        StreamWriter streamWrite = new StreamWriter(filePath);
                        streamWrite.Write(ex.GetType().Name);
                        streamWrite.WriteLine();
                        streamWrite.Write(ex.Message);
                        streamWrite.Close();
                        Console.WriteLine("There is a Problem, Please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);
                    }


                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception " + exception.GetType().Name);
                if(exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception " + exception.InnerException.GetType().Name);
                }
                
            }

            


        }
    }
}
