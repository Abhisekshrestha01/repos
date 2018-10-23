using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapChar
{
    public class Swapchar
    {
        public string SwapNC(params Char[] arr)
        {
            int x = (arr.Length % 2);
            for (int i = 0; i < arr.Length - x; i += 2)
            {
                char temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }

            return String.Concat(arr);
        }
    }
}
