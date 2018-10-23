using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairOfElement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool status3 = true;
            int x = 0;
            
            do
            {

                Console.WriteLine("Enter the valid array size");

                status3 = int.TryParse(Console.ReadLine(), out x);
            } while (status3 == false);

            Console.WriteLine("Enter "+x+ " numbers");
            int[] intarray = new int[x];
            List<string> Result = new List<string>();
            int sum = 0;
            bool status = true;
            bool status1 = true;
            for (int i = 0; i < x; i++)
            {
                do
                {
                    Console.WriteLine("Interger int[{0}]:", i);
                    status = int.TryParse(Console.ReadLine(), out intarray[i]);
                } while (status == false);
                
            }
            
            do
            {

                Console.WriteLine("Enter the required sum for the pair of numbers");

                status1 = int.TryParse(Console.ReadLine(), out sum);
            } while (status1 == false);


            for (int j = 0; j < x; j++)
            {
                    for(int k = 0; k < x; k++)
                    {
                        if((intarray[j]>intarray[k])||(j == k))
                        {
                            continue;
                        }
                        if(intarray[j] + intarray[k] == sum)
                        {
                            Result.Add("(" + intarray[j] + " , " + intarray[k] + ")");
                        }
                    }
            }
            if(Result.Any())
            {
                Console.WriteLine("The pair is:");
                foreach (string temp in Result)
                {
                    Console.WriteLine(temp);
                }
            }
            else
            {
                Console.WriteLine("There is no pair for that sum");
            }
            
            
        
        }
    }
}
