using System;

namespace CountWS
{
    public class CountWholeSquare
    {
        public static int Solution(int a, int b)
        {
            int count = 0;
            for(int i = a; i <= b; i++)
            {
                if((Math.Sqrt(i))-(int)(Math.Sqrt(1))==0)
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}
