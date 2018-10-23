using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Have a nice day Have you";
            string str2 = "have you"; 
            List<string> strlist1 = str1.Split(' ').ToList();
            List<string> strlist2 = str2.Split(' ').ToList();
            //List<string> finallist = strlist1.AddRange(strlist2);
            strlist1.Remove(strlist2[0]);
            strlist1.Remove(strlist2[1]);
            foreach(string a in strlist1)
            {
                Console.Write(a);
                Console.Write(" ");
            }
            //foreach(string b in strlist2)
            //{
            //    Console.Write(b);
            //    Console.Write(" ");
            //}



        }
    }
}
