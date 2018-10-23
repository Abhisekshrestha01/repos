using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int number = Convert.ToInt32(Console.ReadLine());
            int reversenumber = 0;
            int y = 0;
            do
            {
                y = number % 10;
                number = number / 10;
                reversenumber = (reversenumber * 10) + y;
            } while (number != 0);
            Console.WriteLine(reversenumber);


        }
    }
}
