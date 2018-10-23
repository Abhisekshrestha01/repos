using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Gender gender = (Gender)1;
            int Num = (int)Gender.Unknown;
            //short[] values = (short[])Enum.GetValues(typeof(Gender));
            //foreach(short value in values)
            //{
            //    Console.WriteLine(value);
            //}
            //string[] names = (string[])Enum.GetNames(typeof(Gender));
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
    public enum Gender
    {
        Unknown  =1,
        Male, 
        Female
    }
}
