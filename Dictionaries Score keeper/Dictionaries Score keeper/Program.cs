using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries_Score_keeper
{
    class Program
    {
        static void Main(string[] args)
        {

            var scores = new Dictionary<string, int>();


            while (true)
            {
                Console.Write("Who won this round? ");
                string playerName = Console.ReadLine();

                if (playerName == "")
                {
                    break;
                }

                if (!scores.ContainsKey(playerName))
                {
                    scores[playerName] = 1;

                }
                else
                {
                    scores[playerName]++;
                }
                Console.WriteLine();


                Console.WriteLine("RANKINGS:");

                Dictionary<string, int>.KeyCollection names = scores.Keys;

                IOrderedEnumerable<string> namesSortedByScoreAscending = names.OrderBy(name => scores[name]);
                var namesSortedByScoreDescending = namesSortedByScoreAscending.Reverse();


                foreach (string name in namesSortedByScoreDescending)
                {
                    Console.WriteLine($"{name} {scores[name]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("The game has ended.");



            Console.ReadKey(true);
        }
    }
}
