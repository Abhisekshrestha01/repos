using System;
using System.Collections.Generic;


namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer()
            {
                FirstName = "Simon",
                LastName = "Tan"
            };
            Console.WriteLine(C1.ToString());
             
        }
        public static T Concat<T>(List<T> lst)
        {
            T result = default(T);
            foreach(var a in lst)
            {
                result = a;
            }
            return result;
        }
       
        
    }
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.LastName + ", " + FirstName;
        }
    }
}
