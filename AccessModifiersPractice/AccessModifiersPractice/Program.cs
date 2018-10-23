using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersPractice
{
    public class Customer
    {
        protected int Id;

    }

    public class CorporateCustomer : Customer
    {
       // public void PrintID()
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Customer C = new Customer();
            //Console.WriteLine(C.Id);
        }
    }
}
