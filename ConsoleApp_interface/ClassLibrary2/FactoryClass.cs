using ClassLibrary1;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryClass
{
    public class FactoryClass1
    {
        public FactoryClass1()
        {

        }
        public static IClass GetObject()
        {
            return new Class1();
        }
    }
}
