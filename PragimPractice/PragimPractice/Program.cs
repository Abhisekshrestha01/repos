using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragimPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            try
            {
                int[] numbers = new int[3];
                numbers[0] = 101;
                numbers[1] = 102;
                numbers[2] = 103;
                Arrayprint(numbers);

                 


            }
            catch(Exception)
            {
                
            }
        }
        public static void Arrayprint(params int[] number)
        {
            Console.WriteLine("The lenght of array is : {0}", number.Length);
            foreach(int k in number)
            {
                Console.WriteLine(k);
            }
            
        }
    }
    
}
 