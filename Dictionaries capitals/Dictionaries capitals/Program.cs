using System;
using System.Collections.Generic;

namespace Dictionaries_capitals
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var capitals = new SortedList<string, string>()
            {
                {"Sweden", "Stockholm" },
                {"Denmark", "Copenhagen" },
                {"Norway", "Oslo" },
                {"Finland", "Helsinki" },
                {"Iceland", "Reykjavik" },

            };


            int randomIndex = random.Next(capitals.Count);
            string randomCountry = capitals.Keys[randomIndex];


            Console.WriteLine($"What is the capital of {randomCountry} ?");


            string playerAnswer = Console.ReadLine();
            string correctAnswer = capitals[randomCountry];

            Console.WriteLine();
            if (playerAnswer == correctAnswer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect! It is {correctAnswer}");
            }


            Console.ReadKey(true);
        }
    }
}
