using System;
using System.Collections.Generic;

namespace Algorithm_2__Party_shuffle
{
    class Program
    {
        /*
            -- To shuffle an array a of n elements (indices 0..n-1):
           for i from n−1 downto 1 do
                   j ← random integer such that 0 ≤ j ≤ i
                   exchange a[j] and a[i]
           */

        static Random random = new Random();

        static void ShuffleList(List<string> items)
        {
            for (int i = items.Count-1; i >= 1; i--)
            {
                int j = random.Next(0, i+1);
                (items[i], items[j]) = (items[j], items[i]);
            }

        }

        static void Main(string[] args)
        {
            var participants = new List<string> { "Hifumi", "Frevor", "Takuma", "Ivar", "Little Light" };

            Console.Write("The participants who signed up are: ");
            Console.WriteLine(string.Join(", ", participants));
            Console.WriteLine();
            Console.WriteLine("     Now to generate the order...");
            Console.WriteLine();


            ShuffleList(participants);
            Console.WriteLine(string.Join(", ", participants));





            Console.ReadKey(true);
        }
    }
}
