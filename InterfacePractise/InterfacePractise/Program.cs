using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractise
{
    interface ICustomer
    {
        void Print();
    }
    interface I2
    {
        void I2Method();
    }
    class Customer : ICustomer, I2
    {
        public void I2Method()
        {
            Console.WriteLine("I2 Method");
        }

        public void Print()
        {
            Console.WriteLine("Interface Print Method");
        }
    }
    class Sample
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print();
        }
    }
}
