using System;
using System.Collections.Generic;

namespace Basilisk_Fighting_back
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int BasiliskHealth = 0;

            var adventurers = new List<string> { "Cain", "Landt", "Faldrek", "Baird" };
            var fallen = new List<string> { };

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

                    dmg += random.Next(1, 5);

                    BasiliskHealth -= dmg;

                    Console.Write($"{name} attacks, and he deals {dmg} damage.");

                    if (BasiliskHealth <= 0)
                    {
                        break;
                    }

                    Console.WriteLine($" The basilisk has {BasiliskHealth} HP left.");
                }

                if (BasiliskHealth <= 0)
                {
                    break;
                }

                int targetIndex = random.Next(adventurers.Count);
                string targetName = adventurers[targetIndex];

                Console.WriteLine();
                Console.WriteLine($"The basilisk flails, setting his petrifying gaze on {targetName}.");

                int constitution = 5;

                int constRoll = random.Next(1, 21);
                constitution += constRoll;
                if (constitution >= 12)
                {
                    Console.WriteLine($"{targetName} rolls {constRoll}, managing to narrowly escape its deadly eyes. ");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"He rolls {constRoll}. The basilisk's gaze meets his own.\n{targetName} crumbles, turning to stone.");
                    Console.WriteLine();


                    fallen.Add(targetName);
                    adventurers.Remove(targetName);
                }

                int alive = (adventurers.Count);
                if (alive == 0)
                {
                    break;
                }


                //Console.WriteLine($"You have {adventurers.Count} heroes left.");
                //Console.WriteLine();

            }

            if (BasiliskHealth <= 0)
            {
                Console.WriteLine(" The basilisk has 0 left.");
                Console.WriteLine();
                Console.Write("The Basilisk has been downed and now lay defeated.");

                if (adventurers.Count < 4)
                {
                    int alive = (adventurers.Count);

                    Console.Write(" But so do your fallen allies as well. ");
                    Console.Write(String.Join(" and ", fallen));
                    Console.Write(" have been frozen in time as statues of stone.\nThere were legends that say if the basilisk dies, the people it petrified would return to what they were. Alas, reality shows no such kindness.\n");
                    if (alive == 1)
                    {
                        Console.WriteLine("Now only a single man stands in flesh, his path lost before his fallen brethren. There will be no songs of mourning this day, only the tears shed by the only one who still remains.");
                    }
                    else
                    {
                        Console.WriteLine("No victory has been claimed by slaying the beast this day, and the heroes remain in silence mourning their fallen.");

                    }

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" Cain and Landt brought each other into an almost desperate embrace, and the group breathed out in relief to have all made it out alive.");
                    Console.WriteLine(" Baird smiled to his dwarven brother, who with a chuckle and a 'Don't be shy now!' brought the giant of a man into a brotherly hug.");
                    Console.WriteLine();
                    Console.Write(" But as the silence settled, Cain stepped forth, kneeling down by the creature's body.\n  'I do wish there had been another way.'");
                    Console.WriteLine(" He gently stroked its skin, uttering a silent murmur to let it rest with ease in the Wildfather's arms.");
                    Console.WriteLine("  'There are times when these choices have to be made.' Baird laid a hand on his friend's shoulder, 'Even when no true evil has been made.'");
                    Console.WriteLine("  'Come now', he added. 'It is time to go home.'");
                    Console.WriteLine(" With heavy hearts the men leave the cave. Grateful to know what they'd saved, but mourning yet the creature who was as much cursed itself as those who fell prey under its gaze.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Your party has been defeated.");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(" And as the dust settles, and the voices from battle has silenced, the creature hiding in the shadows had long since gone. \n It was all silent now, with not even the voice of the winds reaching them where they were.");
                Console.WriteLine(" The statues, once men now stood there like a mockery of what they'd once been. Like elegant portrayals, of anger, of loss, of desperation.");
                Console.WriteLine(" And in their midst he stood, as calm as a gentle god himself. To think a man turnt to stone could look so much at peace.");
                Console.WriteLine();
                Console.WriteLine(" The voice of the creature who had made them so cried in the distance. As if echoing the agony of the lives it had claimed. As it would continue to do forevermore.");


                //the voice crying in the distance. 
            }




            Console.ReadKey(true);
        }
    }
}
