using System;
using System.Collections.Generic;

namespace practicetest
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<num;i++)
            {
                string str = Console.ReadLine();
                string substring = str.Substring(0, 4);
                Note note = new Note();
                Coin coin = new Coin();
                switch (substring.ToLower())
                {
                    case "coin":
                        coin.SetValue(Convert.ToInt32(str.Substring(5)));
                        break;
                    case "note":
                        note.SetValue(Convert.ToInt32(str.Substring(5)));
                        break;
                    default:
                        Console.WriteLine("Please enter the valid input");
                        break;


                }
            }
            
            Console.WriteLine("Coins :");
            foreach(int val in Bag.coinList)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("Notes :");
            foreach (int val in Bag.noteList)
            {
                Console.WriteLine(val);
            }
            
        }
    }
    class Bag
    {
        public static List<int> coinList = new List<int>();
        public static List<int> noteList = new List<int>();
    }
    class Note:Bag
    {
        public int val;
        public void SetValue(int val)
        {
            noteList.Add(val);
        }
    }
    class Coin:Bag
    {
        public int val;
        public void SetValue(int val)
        {
            coinList.Add(val);
        }
    }
}
