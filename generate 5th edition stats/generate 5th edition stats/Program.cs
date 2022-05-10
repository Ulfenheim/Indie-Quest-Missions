using System;
using System.Collections.Generic;

namespace generate_5th_edition_stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var availableAbility = new List<int>();

            for (int setRoll = 0; setRoll < 6; setRoll++)
            {
                int Score = 0;
                var Rolls = new List<int>();

                for (int dice = 0; dice < 4; dice++)
                {
                    int diceRoll = random.Next(1, 7);
                    Rolls.Add(diceRoll);
                    Score += diceRoll;


                    //Console.Write($"{diceRoll} ");

                }
                Console.Write("The blessing of the graceful Stag grants you ");
                Console.Write(string.Join(", ", Rolls)); Console.Write(".");
                Console.WriteLine();


                Rolls.Sort();
                Score -= Rolls[0];
                Console.WriteLine($"Your favor gathers to a total sign of {Score}.");
                availableAbility.Add(Score);
                Console.WriteLine();


            }
            availableAbility.Sort();
            Console.WriteLine();
            Console.Write("Upon you are bestowed the choice to freely assign ");
            Console.Write(string.Join(", ", availableAbility)); Console.WriteLine(".");
            Console.WriteLine("Choose your strengths wisely, little light.");

            Console.ReadKey(true);
        }
    }
}
