using System;
using System.Collections.Generic;

namespace Basilisk
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int BasiliskHealth = 0;

            var adventurers = new List<string> { "Cain", "Landt", "Faldrek", "Baird" };

            Console.WriteLine($"Your warriors are {adventurers[0]}, {adventurers[1]}, {adventurers[2]} and {adventurers[3]}.\n A mighty fine group of men if I may say so myself. You have been lucky, Player.");


            for (int basilisk = 0; basilisk < 8; basilisk++)
            {
                int diceRoll = random.Next(1, 9);
                BasiliskHealth += diceRoll;
            }

            BasiliskHealth += 16;


            Console.WriteLine();
            Console.WriteLine($"Suddenly! A basilisk appears with {BasiliskHealth} HP!");
            Console.WriteLine();


            while (BasiliskHealth > 0)
            {
                foreach (var name in adventurers)
                {
                    int dmg = 0;

                    for (int attack = 0; attack < 2; attack++)
                    {
                        dmg += random.Next(1, 9);
                    }

                    BasiliskHealth -= dmg;
                                        
                    Console.Write($"{name} attacks, and he deals {dmg} damage.");

                    if (BasiliskHealth <= 0)
                    {
                        break;
                    }

                    Console.WriteLine($" The basilisk has {BasiliskHealth} left.");

                }

            }

            Console.WriteLine(" The basilisk has 0 left.");
            Console.WriteLine();
            Console.WriteLine("Oh, you... broke the loop. The Basilisk has been downed and now lay defeated,\n without as much as a single chance to display resistance. Oh the poor thing.");


















            /*

            while (BasiliskHealth > 0)
            {

                int CainDmg = 0;
                int LandtDmg = 0;
                int FaldDmg = 0;
                int BairdDmg = 0;

                for (int Cain = 0; Cain < 2; Cain++)
                {
                    int diceRoll = random.Next(1, 7);
                    CainDmg += diceRoll;
                }

                Console.Write($" {adventurers[0]} attacks, and he deals {CainDmg} damage. ");
                BasiliskHealth -= CainDmg;

                //if (CainDmg < 5)
                //{
                //    Console.Write("Oh, wow. And he's supposed to be the swordsman of the group... ");
                //}

                if (BasiliskHealth <= 0)
                {
                    break;
                }

                Console.WriteLine($"The Basilisk now has {BasiliskHealth} HP.");



                for (int Landt = 0; Landt < 2; Landt++)
                {
                    int diceRoll = random.Next(1, 7);
                    LandtDmg += diceRoll;
                }


                Console.Write($" {adventurers[1]} attacks, and he deals {LandtDmg} damage. ");
                BasiliskHealth -= LandtDmg;

                if (BasiliskHealth <= 0)
                {
                    break;
                }

                Console.WriteLine($"The Basilisk now has {BasiliskHealth} HP.");

                for (int Faldrek = 0; Faldrek < 2; Faldrek++)
                {
                    int diceRoll = random.Next(1, 7);
                    FaldDmg += diceRoll;
                }

                Console.Write($" {adventurers[2]} attacks, and he deals {FaldDmg} damage. ");
                BasiliskHealth -= FaldDmg;
                //if (FaldDmg > 7)
                //{
                //    Console.Write("And he's a rogue?! Faldrek, you make me proud! ");
                //}

                if (BasiliskHealth <= 0)
                {
                    break;
                }

                Console.WriteLine($"The Basilisk now has {BasiliskHealth} HP.");

                for (int Baird = 0; Baird < 2; Baird++)
                {
                    int diceRoll = random.Next(1, 7);
                    BairdDmg += diceRoll;
                }

                Console.Write($" {adventurers[3]} attacks, and he deals {BairdDmg} damage. ");
                BasiliskHealth -= BairdDmg;

                if (BasiliskHealth <= 0)
                {
                    break;
                }

                Console.WriteLine($"The Basilisk now has {BasiliskHealth} HP.");

            }

            Console.Write($"The Basilisk now has 0 HP.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Oh, you... broke the endless loop. The Basilisk has been downed and now lay defeated.");

            */

            Console.ReadKey(true);
        }
    }
}
