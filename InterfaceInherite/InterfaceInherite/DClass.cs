using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInherite
{
    class DClass: PClass, Interf
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
