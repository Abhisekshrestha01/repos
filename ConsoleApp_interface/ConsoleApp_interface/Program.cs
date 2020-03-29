using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryClass;
using Interfaces;

namespace ConsoleApp_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 3;
            IClass class1 = FactoryClass1.GetObject();
            int sum = class1.sum(a, b);
        }
    }
}
