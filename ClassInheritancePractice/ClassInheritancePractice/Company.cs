using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritancePractice
{
    class Company
    {
        public Company()
        {
            Console.WriteLine("This is Parent Class Company");
        }
        public Company(int capital)
        {
            Console.WriteLine("The total worth of Parent Company is :"+capital);
        }
        // a rank private variable will be created
        public int Rank
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public virtual void PrintDetail()
        {
            Console.WriteLine("The rank of the company is:"+ this.Rank +" and address is :" + this.Address);
        }

    }
}
