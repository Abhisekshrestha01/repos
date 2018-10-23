using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractise1
{
    class Circle
    {
        static float _PI;
        int _Radius;

        static Circle()
        {
            Circle._PI = 3.141f;
        }

        public Circle(int radius)
        {
            this._Radius = radius;
        }

        public float CalculateArea()
        {
            return _PI * this._Radius * this._Radius;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(6);
            float Area1 = C1.CalculateArea();
            Console.WriteLine("The Area is : {0}", Area1);

            Circle C2 = new Circle(8);
            float Area2 = C2.CalculateArea();
            Console.WriteLine("The Area is : {0}", Area2);


        }
    }
}
