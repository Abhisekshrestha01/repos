using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s1 = Console.ReadLine();
            char[] chararray = s1.ToCharArray();
            string rs1 = string.Empty;
           for(int i = chararray.Length-1; i>=0;i--)
            {
                rs1 += chararray[i];
            }
            Console.WriteLine(rs1.ToString());
        }
    }
}
