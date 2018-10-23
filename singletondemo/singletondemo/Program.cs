using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => Prints1(),
                () => Prints2()
                );
           
           
            Console.ReadLine();
        }

        private static void Prints2()
        {
            Singleton s2 = Singleton.GetInstance;

            s2.print("This is second one");
        }

        private static void Prints1()
        {
            Singleton s1 = Singleton.GetInstance;

            s1.print("This is first one");
        }
    }
}
