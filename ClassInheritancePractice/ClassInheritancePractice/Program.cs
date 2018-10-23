using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritancePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //base class
            IMCS IMCSBranch = new IMCS(10000,100);
            IMCSBranch.Rank=5;
            IMCSBranch.Address="Dallas";
            //overriding
            IMCSBranch.PrintDetail();
            //overloading
            Console.WriteLine("The Total tax paid is:" +IMCSBranch.TaxPay(10000));
            Console.WriteLine("The total tax paid with rate:"+IMCSBranch.TaxPay(10000,0.2));

            
        }
    }
}
