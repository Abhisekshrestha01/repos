using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractise
{
    public abstract class Customer
    {
        public abstract void Print();
    }
    public class Program : Customer
    {
        public override void Print()
        {
            Console.WriteLine(" Print Method ");
        }
        static void Main(string[] args)
        {
            Customer C = new Program();
            C.Print();
        }
    }
}
