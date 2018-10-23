using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInherite
{
    class Program
    {
        static void Main(string[] args)
        {
            DClass obj = new DClass();
            Console.WriteLine("The sum is:" + obj.Sum(1, 3));
            obj.Print();
        }
    }
}
