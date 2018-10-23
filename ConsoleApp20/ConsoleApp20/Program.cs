using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the Number:");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Second:");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;
                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\SampleFile\textfile.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name);
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a Problem, Please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + "is not present", ex);
                    }

                }
            }catch(Exception exception)
            {
                Console.WriteLine("Current exception = {0}",exception.GetType().Name);
                if(exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
                }
                

            }
            
            
        }
    }
}
