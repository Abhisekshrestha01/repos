
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inpkementation_EPractise
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
    public class Program :  I1, I2
    {
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }

        static void Main(string[] args)
        {
            Program P = new Program();
            P.InterfaceMethod();
            ((I2)P).InterfaceMethod();
            
        }

        
    }
}
