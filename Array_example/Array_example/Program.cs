using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_example
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] Evennumbers = new int[10];
                int[] oddnumbers = new int[10];
                int even = 0;
                int odd = 0;
                
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Enter the number :");
                    int i = Convert.ToInt32(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        Evennumbers[even] = i;
                        even++;
                    }
                    else
                    {
                        oddnumbers[odd] = i;
                        odd++;
                    }


                }
                Console.WriteLine("Evennumbers :");
                for (int m = 0; m <= 5; m++)
                {
                    
                    Console.WriteLine(Evennumbers[m]);
                    
                }
                Console.WriteLine("oddnumbers :");
                for (int n = 0; n <= 5; n++)
                {
                   
                    Console.WriteLine(oddnumbers[n]);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Error");
            }


        }
    }
}
