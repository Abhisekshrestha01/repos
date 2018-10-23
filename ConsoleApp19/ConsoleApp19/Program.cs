using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class User1
    {
        public User1()
        {
            Console.WriteLine("This is Parent Class");
        }
        public User1(int a, int b)
        {
            Console.WriteLine("Parent: " + a + " " + b);
        }
    }
    public class User2 : User1
    {
        public User2()
        {
            Console.WriteLine("Child :Hello guys");
        }

        public User2(int a) 
        {
            Console.WriteLine("Child :"+a);
        }
        public User2(int a, int b, int c) : base(a, b)
        {
            Console.WriteLine("Child"+ a+ " "+ b +" "+c);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var user = new User2(1);
            var user1 = new User2(1, 2, 3);
            var user2 = new User2();
            
            
            
        }
    }
}
