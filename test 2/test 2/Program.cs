using System;

namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try {
                var a = 10;
                var b = 3;
                Console.WriteLine(a>b);
            }
            catch (Exception )
            {
                Console.WriteLine("An error has occured");
            }
  
        }
    }
    
}
