using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structurePractise
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public int Id
        {
            set { this._id = value; }
            get { return this._id; }
        }

        public string Name { get => _name; set => _name = value; }

        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Customer Id = {0} and Name = {1}", this._id, this._name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C = new Customer(101, "Abhisek");
            C.PrintDetails();

            Customer C2 = new Customer();
            C2.Id = 102;
            C2.Name = "Abhisek1";
            C2.PrintDetails();

            Customer C3 = new Customer
            {
                Id = 103,
                Name = "AbhisekShrestha"
            };
            C3.PrintDetails();
            
        }
    }
}
