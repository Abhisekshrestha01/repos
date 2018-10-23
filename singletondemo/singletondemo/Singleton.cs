using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletondemo
{
    public sealed class Singleton
    {
        public static int count = 0;
        private static readonly object obj = new object();
        public static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                            instance = new Singleton();
                        
                    }
                }
                return instance;

            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine(count);
        }
        public void print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
