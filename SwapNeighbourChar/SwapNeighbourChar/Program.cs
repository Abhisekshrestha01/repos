using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwapChar;

namespace SwapNeighbourChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to swap the char");
            string str = Console.ReadLine();
           
            Char[] temp_chararray = str.ToCharArray();
          
            Swapchar c1 = new Swapchar();
            string result = c1.SwapNC(temp_chararray);
            Console.WriteLine("The result is "+ result);
        }
    }
    
}
