using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaceInherite
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Child c1 = new Child();
            Console.WriteLine("Calling from Child:");
            ((I1)c1).PrintDetail();
            Console.WriteLine("Calling from Child:");
            ((I2)c1).PrintDetail();
        }  
    }
    public class Child: I1, I2
    {
        void I1.PrintDetail()
        {
            Console.WriteLine("This is Interface 1");
        }
        void I2.PrintDetail()
        {
            Console.WriteLine("This is Interface 2");
        }
    }
    interface I1
    {
        void PrintDetail();
    }
    interface I2
    {
        void PrintDetail();
    }
}

