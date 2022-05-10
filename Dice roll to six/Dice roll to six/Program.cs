using System;

namespace Dice_roll_to_six
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int diceroll;
            int Total = 0;
            do
            {
               diceroll = random.Next(1, 7);
                Total += diceroll;
                Console.WriteLine($"The dice rolls: {diceroll}");
            } while (diceroll < 6);
            Console.WriteLine($"Total score: {Total}");

            Console.ReadKey(true);
        }
        
    }
}