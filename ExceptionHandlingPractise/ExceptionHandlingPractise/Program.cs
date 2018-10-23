using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandlingPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try {
                streamReader = new StreamReader(@"C:\Users\shres\Desktop\Data1.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                

            }
            catch(FileNotFoundException ex)
            {
                //Log the details to the DB
                Console.WriteLine("Please check if the file {0} exists", ex.FileName);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                if (streamReader != null)
                {
                    streamReader.Close();
                }
                 Console.WriteLine("Finally Block");
            }
            
            
        }
    }
}
