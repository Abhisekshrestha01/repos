using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculation
{
    public class Calculate
    {
        public void Countwholesquare(int a, int b,out int count, out List<int> lst)
        {
            count = 0;
            lst = new List<int>();
            for (int i = a; i <= b; i++)
            {
                if ((Math.Sqrt(i)) == Math.Floor((Math.Sqrt(i))))  
                {
                    count++;
                    lst.Add(i);
                }
                
                
            }
            
        }
    }
}
