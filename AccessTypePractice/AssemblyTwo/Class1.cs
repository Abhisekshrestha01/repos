using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass
    {
        public void Test()
        {
            AssemblyOneClass instance = new AssemblyOneClass();
            instance.Print();
        }
    }
}
