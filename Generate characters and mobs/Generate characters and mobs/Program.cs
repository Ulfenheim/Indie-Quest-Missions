using System;

namespace Generate_characters_and_mobs
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int strength = 0;
            int slimeHP = 40;
            int slimeArmy = 400;

            for (int diceRolled = 0; diceRolled < 3; diceRolled++)
            {
                int diceRoll = random.Next(1, 7);
                strength += diceRoll;
            }

            for (int slimeRoll = 0; slimeRoll < 8; slimeRoll++)
            {
                int diceRoll = random.Next(1, 11);
                slimeHP += diceRoll;
            }

            for (int x = 0; x < 100; x++)
            {
                for (int slimeRoll = 0; slimeRoll < 8; slimeRoll++)
                {
                    int diceRoll = random.Next(1, 11);
                    slimeArmy += diceRoll;

                }
            }

            Console.WriteLine($"Your character's strength is {strength}.");
            Console.WriteLine($" You hear rustling from the nearby bushes. A slime has appeared with {slimeHP} HP!\n Bring out your weapons and prepare to face- No, wait...");
            Console.WriteLine();
            Console.WriteLine($" By Iskar's beard, an army of a hundred slimes descends upon us with a total of {slimeArmy} HP. Cain, hide your manlihood. We are doomed!");

            //By Iskar's beard, an army of 100 slimes descends upon us with a total of {slimeArmy} HP. Cain, hide your manlihood. We are doomed!

            Console.ReadKey(true);
        }
    }
}