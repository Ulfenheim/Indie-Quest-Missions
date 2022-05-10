using System;

namespace Arrays
{
    class Program
    {

        //Objective: Seasons
        static string CreateDayDescription(int day, int season, int year)
        {
            string[] Seasons = { "Spring", "Summer", "Fall", "Winter" };

            return "Day " + day + " of " + Seasons[season] + " in the year " + year;
        }


        static void Main(string[] args)
        {

            //Mission 1: Objective: Seasons
            Console.WriteLine(CreateDayDescription(3, 3, 600));
            Console.WriteLine();

            //Mission 2: Objective: Increasing level difficulty
            var random = new Random();
            int[] numbers = new int[100];

            for (int i = 0; i < 100; i++)
            {
                numbers[i] = random.Next(1, 51);
            }
            Array.Sort(numbers);

            Console.Write("The number of monsters in each level: " + string.Join(", ", numbers));
            Console.WriteLine();


            Console.ReadKey(true);
        }
    }
}
