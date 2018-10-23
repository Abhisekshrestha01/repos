using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 3, -4, 7, 0, -6, 5 };
        var posNums = nums.Where(n => n > 0).Select(r => r * 2).OrderByDescending(r => r);
        foreach (int i in posNums)
            Console.Write(i + " ");
    }
}