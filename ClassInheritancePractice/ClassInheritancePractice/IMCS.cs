using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritancePractice
{
    class IMCS : Company, ICompany
    {
        public IMCS()
        {
            Console.WriteLine("This is a IMCS Company");
        }
        public IMCS(int capital, int loan) : base(capital)
        {
            Console.WriteLine("Capital :"+capital+"loan :"+loan);
        }

        public IMCS(string rank, string address)
        {
            Console.WriteLine("The rank :"+rank+" and address:"+address);
        }
        //overriding
        public override void  PrintDetail()
        {
            Console.WriteLine("The IMCS company rank : "+this.Rank+" and address:"+ this.Address);
        }
        //overloading
        public double TaxPay(int income)
        {
            double tax = income * 0.1;
            return tax;
        }
        public double TaxPay(int income, double rates)
        {
            double tax = income * rates;
            return tax;
        }

    }
}
