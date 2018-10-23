using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragimPractise3
{
    class Customer
    {
        string _firstname;
        string _lastname;

        public Customer() 
            : this("No FirstName Provided", "No LastName Provided")
        {

        }

        public Customer(string Firstname, string Lastname)
        {
            this._firstname = Firstname;
            this._lastname = Lastname;

        }
        public void PrintFullName()
        {
            Console.WriteLine("Fullname = {0} {1}",this._firstname, this._lastname);
        }

        ~Customer()
        {
            //Clean up code
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.PrintFullName();

            Customer C2 = new Customer("A", "S");
            C2.PrintFullName();
        }
    }
}
