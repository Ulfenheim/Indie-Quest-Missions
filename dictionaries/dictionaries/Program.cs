using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var games = new Dictionary<int, string>()
            {
                {2018, "South Korea" },
                {2016, "Brazil" },
                {2014, "Russia" },
                {2012, "United Kingdom" },
                {2010, "Canada" },
                {2008, "China" },
                {2006, "Italy" },
                {2004, "Greece" },
                {2002, "United States" },
                {2000, "Australia" },
                {1998, "Japan" }
            };


            int randomIndex = random.Next(games.Count);
            int randomYear = games.Keys.ToList()[randomIndex];


            Console.WriteLine($"Which country hosted the Olympic Games in {randomYear} ?");

            string playerAnswer = Console.ReadLine();
            string correctAnswer = games[randomYear];

            Console.WriteLine();
            if (playerAnswer == correctAnswer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect! It was {correctAnswer}");
            }


            Console.ReadKey(true);
        }
    }
}
