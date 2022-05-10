using System;

namespace Regenerative_Spell
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int HP = random.Next(1, 101);
            if (HP < 50)
            {
                Console.WriteLine("Restoration has been cast!");
            }
            while (HP < 50)
            {                
                Console.WriteLine($"Health: {HP}");
                HP+=10;
                if (HP > 50)
                {
                    Console.WriteLine("Restoration has worn off.");
                }
            }
            
            Console.WriteLine($"Your HP is now: {HP}");
            Console.ReadLine();
        }
    }
}