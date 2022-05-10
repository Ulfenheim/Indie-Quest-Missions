using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm_2
{
    class Program
    {

        static string JoinWithAnd(List<string> items, bool useSerialComma = true)
        {
            int count = items.Count;

            if (count == 0)
            {
                return "";
            }
            else if (count == 1)
            {
                return items[0];
            }
            else if (count == 2)
            {
                return string.Join(" and ", items);
            }
            else
            {
                var itemsCopy = new List<string>(items);

                if (useSerialComma)
                {
                    itemsCopy[count - 1] = ("and " + itemsCopy[count - 1]);
                }
                else
                {
                    itemsCopy[count - 2] = itemsCopy[count - 2] + " and " + itemsCopy[count - 1];
                    itemsCopy.RemoveAt(itemsCopy.Count - 1);
                }
                return string.Join(", ", itemsCopy);
            }

        }

        static void Main(string[] args)
        {
            var heroes = new List<string> { "Cain", "Baird", "Landt", "Berhardt" };
            var heroes3 = new List<string> { "Cain", "Baird", "Landt" };
            var heroes2 = new List<string> { "Cain", "Baird" };
            var heroes1 = new List<string> { "Cain" };


            Console.WriteLine(JoinWithAnd(heroes, false));
            Console.WriteLine(JoinWithAnd(heroes3, false));
            Console.WriteLine(JoinWithAnd(heroes2, false));
            Console.WriteLine(JoinWithAnd(heroes1, false));
            Console.WriteLine();
            Console.WriteLine(JoinWithAnd(heroes));
            Console.WriteLine(JoinWithAnd(heroes3));
            Console.WriteLine(JoinWithAnd(heroes2));
            Console.WriteLine(JoinWithAnd(heroes1));

            Console.ReadKey(true);
        }

    }
}
