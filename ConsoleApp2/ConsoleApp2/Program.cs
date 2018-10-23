using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000

            };
        Customer customer2 = new Customer()
        {
            ID = 110,
            Name = "Pam",
            Salary = 6500

        };
        Customer customer3 = new Customer()
        {
            ID = 119,
            Name = "John",
            Salary = 5000

        };
            Dictionary<int, Customer> dictionaryKeyValuePair = new Dictionary<int, Customer>();
            dictionaryKeyValuePair.Add(customer1.ID, customer1);
            dictionaryKeyValuePair.Add(customer2.ID, customer2);
            dictionaryKeyValuePair.Add(customer3.ID, customer3);
            if(!dictionaryKeyValuePair.ContainsKey(customer1.ID))
            {
                dictionaryKeyValuePair.Add(customer3.ID, customer3); 
            }
            //Customer cust_temp = dictionaryKeyValuePair[135];

            //foreach(var customerKeyValuePair in dictionaryKeyValuePair)
            //{

            //    Customer cust = customerKeyValuePair.Value;
            //    Console.WriteLine(cust.ID +" "+ cust.Name+" "+ cust.Salary);
            //}
            //Console.ReadLine();

            //TrryGervalue
            //Customer cust2;
            //if(dictionaryKeyValuePair.TryGetValue(101, out cust2))
            //{
            //    Console.WriteLine(cust2.Name);
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("The Key is not found");
            //}

            //count
            //int x = dictionaryKeyValuePair.Count;
            //Console.WriteLine(x);
            //Console.ReadLine();

            Customer[] cust3 = new Customer[3];
            cust3[0] = customer1;
            cust3[1] = customer2;
            cust3[2] = customer3;

            //Console.WriteLine(cust3[0].ID);
            //Console.WriteLine(cust3[1].ID);
            //Console.WriteLine(cust3[2].ID);
            //Console.ReadLine();

            Dictionary<int, Customer> dict = cust3.ToDictionary(cust => cust.ID, cust => cust);

            foreach(KeyValuePair<int, Customer> x in dict)
            {
                Console.WriteLine(x.Key);
                Customer cust = x.Value;
                Console.WriteLine(cust.ID + " " + cust.Name + " " + cust.Salary);
                Console.ReadLine();
            }
        }
    }
}
