using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Calculator.Add(new List<int>() {10,20, 40 });
            Console.WriteLine(sum);
            
        }

    }
    public class Calculator
    {
        [ObsoleteAttribute("Use Add(List<int> Numbers) Method")]
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(List<int> Numbers)
        { 
            int sum = 0;
            foreach(int number in Numbers)
            {
                sum = sum + number;
            }
            return sum;
        }
    }
}
