using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Sample sample = new Sample("ASDF",13);
            var type = sample.GetType();

            Console.WriteLine(type);
            if(sample is Sample)
            {
                var properties = type.GetProperties();
                foreach (var property in properties)
                {
                    Console.WriteLine(property.Name);
                }
                
            }
            Console.ReadLine();
        }
    }
    [Myclass]
    public class Sample
    {
        public string Name { get; set; }
        public int _ID;
        public Sample( string name, int id)
        {
            this.Name = name;
            this._ID = id;
        }
        public void MyMethod()
        {
            Console.WriteLine("Hello form method");
        }


    }
    [AttributeUsage(AttributeTargets.Class)]
    public class MyclassAttribute:Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Method)]
    public class MyMethodAttribute:Attribute
    {

    }
}
