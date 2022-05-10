using System;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int bowl = random.Next(0, 11);
            int result = bowl;

            if (bowl == 10)
            {
                Console.Write($"First roll: X \n");
            }
            else
            {
                if (bowl == 0)
                {
                    Console.Write($"First roll: - \n");
                }
                else
                {
                    Console.Write($"First roll: {bowl}\n");
                }

                int secondBowl = random.Next(0, 11 - bowl);
                result += secondBowl;

                if (secondBowl == 0)
                {
                    Console.Write($"Second roll: -\n");
                }
                else if (result == 10)
                {
                    Console.Write($"Second roll: /\n");
                }
                else
                {
                    Console.Write($"Second roll: {secondBowl}\n");
                }
            }

            Console.Write($"Knocked Pins: {result}");

            Console.ReadKey(true);
        }
    }
}
