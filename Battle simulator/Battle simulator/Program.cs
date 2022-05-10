using System;
using System.Collections.Generic;

namespace Battle_simulator
{
    class Program
    {
        static int DiceRoll(int numberOfRolls, int diceSides, int fixedBonus = 0)
        {
            var random = new Random();
            int totalScore = 0;

            for (int i = 0; i < numberOfRolls; i++)
            {
                totalScore += random.Next(1, diceSides + 1);
            }
            totalScore += fixedBonus;
            return totalScore;
        }

        static void SimulateBattle(List<string> heroes, string monster, int monsterHP, int savingThrowDC)
        {
            var random = new Random();

            Console.WriteLine();
            Console.WriteLine($"Out of the shadows, {monster} appears with {monsterHP} health!");
            Console.WriteLine();


            while (monsterHP > 0)
            {


                foreach (var name in heroes)
                {
                    int dmg = 0;

                    dmg = DiceRoll(2, 6);

                    monsterHP -= dmg;
                    Console.Write($"{name} attacks, and he deals {dmg} damage.");


                    if (monsterHP <= 0)
                    {
                        Console.WriteLine($" The creature has no health left. \nYour party has slain the {monster}!");
                        break;
                    }

                    Console.WriteLine($" The creature has {monsterHP} HP left.");
                }


                if (monsterHP <= 0)
                {
                    break;
                }


                int targetIndex = random.Next(heroes.Count);
                string targetName = heroes[targetIndex];

                Console.WriteLine();
                Console.WriteLine($"The {monster} attacks, lunging at {targetName}.");

                int constitution = 5;
                int constRoll = random.Next(1, 21);
                constitution += constRoll;
                if (constitution >= savingThrowDC)
                {

                    Console.WriteLine($"{targetName} rolls {constRoll}, managing to withstand the blow. ");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{targetName} rolls {constRoll} and fails to withstand the blow. {targetName} is knocked unconcious.");
                    Console.WriteLine();

                    heroes.Remove(targetName);
                }


                if (heroes.Count == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Your heroes have all been defeated.");
                    break;
                }
            }
        }


        static void Main(string[] args)
        {
            var adventurers = new List<string> { "Berhardt", "Baird", "Grimtook", "Falstadt" };

            Console.Write($"A party of ");
            Console.Write(string.Join(", ", adventurers));
            Console.WriteLine(" descends into the dungeon.");

            SimulateBattle(adventurers, "orc", DiceRoll(2, 8, 6), 12);
            SimulateBattle(adventurers, "mage", DiceRoll(9, 8), 20);
            SimulateBattle(adventurers, "troll", DiceRoll(8, 10, 40), 18);

            //Console.WriteLine(adventurers.Count);

            if (adventurers.Count > 0)
            {
                Console.WriteLine();
                Console.Write("Standing victorious after battle, ");

                if (adventurers.Count == 1)
                {
                    Console.Write($"{adventurers[0]} ");
                    Console.WriteLine("hears the coughs of his brethren catching their air. \nHe goes to their side, helping each and every one of them back to their feet.");
                    Console.WriteLine("They came to this battle together, and together they would leave. If he is to gain victory, then they all would.");
                }

                if (adventurers.Count == 2)
                {
                    Console.Write($"{adventurers[0]} and {adventurers[1]} ");
                    Console.WriteLine("hold before the celebration to aid their injured comrades.");
                    Console.WriteLine("They go to their sides, helping them back to their feet.");
                    Console.WriteLine("It was together that they entered this place, together that they fought. \nAnd together, they would leave, celebreating today's victory.");
                }

                if (adventurers.Count == 3)
                {
                    Console.Write($"{adventurers[0]}, {adventurers[1]} and {adventurers[2]} ");
                    Console.Write("look to one another, then to their comrade still on his knees. \nA hearthy chuckle echoes out through the cavern. ");
                    Console.Write("'Oh come on now, lad!' one of them calls out,\n'Didn't think you'd go down that easy.' ");
                    Console.WriteLine("Through brotherly mocking, the brethren help their last man up to his feet and they leave the dungeon together. ");
                }

                if (adventurers.Count == 4)
                {
                    Console.Write($"{adventurers[0]}, {adventurers[1]}, {adventurers[2]} and {adventurers[3]} ");
                    Console.WriteLine("relish in the thrills after. \nWith every man still on their feet, the brethren tug and nudge each other with warm laughter.");
                    Console.WriteLine("All that's left now is to return home, grab a drink, a hearthy meal, and celebrate.");

                }

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Every hero left vulnerable, the creature finishes them off. \nSilence rings out, and all that remains within the rays of light are the still figures that will move no more.");
            }




            /*             
             if (monsterHP <= 0)
            {
                Console.Write("Standing victorious after battle, ");
                if (alive == 1)
                {
                    Console.Write(heroes[0]);
                    Console.WriteLine(" hears the coughs of his brethren catching their air. He goes to their side, helping each and every one of them back to their feet.");
                    Console.WriteLine("They came to this battle together, and together they would leave.");

                }
                else
                {
                    Console.Write(string.Join(", ", heroes));
                    Console.WriteLine(" hold before the celebration to aid their injured comrades.");
                    Console.WriteLine();                       
           */


            Console.ReadKey(true);
        }
    }
}

