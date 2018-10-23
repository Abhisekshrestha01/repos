using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            int ab = 0;
            int an = 0;
            int bi = 0;
            int sh = 0;
            int su = 0;
            while(1 == 1)
            {
                Console.WriteLine("Enter the Luck:");
                str = Console.ReadLine().ToUpper();
                String[] arr = new string[] { "Abhisek", "Anurag", "Bishal", "shreejan", "Sulav" };
                var random = new Random();
                var randomIndex = random.Next(arr.Length);
                switch(arr[randomIndex])
                {
                    case "Abhisek":
                        ab++;
                        break;
                    case "Anurag":
                        an++;
                        break;
                    case "Bishal":
                        bi++;
                        break;
                    case "shreejan":
                        sh++;
                        break;
                    case "Sulav":
                        su++;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The luck guy is :"+arr[randomIndex]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Abhisek : "+ab );
                Console.WriteLine("Anurag : "+an);
                Console.WriteLine("Bishal : "+bi);
                Console.WriteLine("shreejan : "+sh);
                Console.WriteLine("Sulav : "+su);

                
            } 
            

        }
    }
}
