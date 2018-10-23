using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cons_asdfasd
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] arrChar = { "c", "a", "b", "c", "b" };
            for (int i = 0; i < arrChar.Length; ++i)
                for (int j = i + 1; j < arrChar.Length; ++j)
                    if (arrChar[i].CompareTo(arrChar[j]) == 0)
                        Console.WriteLine(arrChar[j]);
            Console.ReadLine();

        }
    }
}
