 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritancePractise
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }
    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
        
    }
    class D : B, C
    {

    }
    class Program
    {

        static void Main(string[] args)
        {
            D d = new D(); 
        }
    }
}
