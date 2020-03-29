using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InerEx
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the first number");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the second number");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(num / num1);
                }
                catch (Exception ex)
                {
                    string filelocation = @"C:\Android1\log.txt";
                    if (File.Exists(filelocation))
                    {
                        StreamWriter sw = new StreamWriter(filelocation);
                        sw.Write(ex.GetType().Name);
                        sw.Close();
                        Console.WriteLine("There is a Problem, Try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filelocation + " not found", ex);
                    }


                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Current Exception " + e.GetType().Name);
                Console.WriteLine("Current Exception " + e.InnerException.GetType().Name);
            }
            finally
            {

            }

        }
    }
}
