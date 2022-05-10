using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var abilityScores = new List<int>();


            for (int setRoll = 0; setRoll < 6; setRoll++)
            {
                int totalScore = 0;
                var scores = new List<int>();
                Console.Write("You roll: ");

                for (int dice = 0; dice < 4; dice++)
                {
                    int diceRoll = random.Next(1, 7);
                    scores.Add(diceRoll);
                    totalScore += diceRoll;

                    Console.Write($"{diceRoll}, ");

                }

                scores.Sort();
                //totalScore -= diceroll[0];
                abilityScores.Add(totalScore);
                
                Console.WriteLine($"with a total Ability score of: {totalScore}");
            }

            Console.WriteLine();
            Console.Write($"Your available Ability scores are: ");


            Console.ReadKey(true);
        }
    }
}
