using System;
using System.Collections.Generic;

namespace Lists_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 10;
            Console.WriteLine();
            //Console.WriteLine($"{n}");

            //List<int> numBers = new List<int> { };
            var numbers = new List<int> { };
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = 0;
                number += random.Next(100);
                numbers.Add(number);
                sum += number;
            }

            double average = sum / n;


            double multiply = numbers[0];
            for (int i = 1; i < 10; i++)
            {
                multiply *= numbers[i];
            }


            Console.WriteLine("The numbers are: ");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
            Console.WriteLine($"The total sum is: {sum}");
            Console.WriteLine();
            Console.WriteLine($"The average of these numbers is: {average} ");
            Console.WriteLine();
            Console.WriteLine($"The product of the ten first numbers are: {multiply}");
            Console.WriteLine();
            numbers.Sort();
            Console.WriteLine("The numbers in order are: ");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();


            List<int> evenNumbers = new List<int> { };
            foreach (int cockSucker in numbers)
            {
                // % is called Modulo (Moduloing in Viktor-speech)
                if (cockSucker % 2 == 0)
                {
                    evenNumbers.Add(cockSucker);
                }
            }
            Console.WriteLine("The even numbers are:");
            Console.WriteLine(string.Join(", ", evenNumbers));


            List<int> topTen = new List<int> { };
            for (int i = n - 10; i < n; i++)
            {
                topTen.Add(numbers[i]);
            }

            Console.WriteLine();
            Console.WriteLine("The ten largest numbers are: ");
            Console.WriteLine(string.Join(", ", topTen));


            List<int> uniqueTen = new List<int> { };
            for (int index = n - 1; index >= 0; index--)
            {
                if (!uniqueTen.Contains(numbers[index]))
                {
                    uniqueTen.Add(numbers[index]);

                    if (uniqueTen.Count == 10)
                    {
                        break;
                    }
                }

                /*
                if (numbers[index] != numbers[index-1])
                {
                    
                }
                */
            }
            Console.WriteLine();
            Console.WriteLine("The ten largest unique numbers are: ");
            Console.WriteLine(string.Join(", ", uniqueTen));


            List<int> uniqueNumbers = new List<int> { };
            for (int index = n - 1; index >= 0; index--)
            {
                if (!uniqueNumbers.Contains(numbers[index]))
                {
                    uniqueNumbers.Add(numbers[index]);

                }
            }
            Console.WriteLine();
            Console.WriteLine($"The original list contains {uniqueNumbers.Count} unique numbers.");

            List<int> missingNumbers = new List<int>();
            for (int number = 0; number < 100; number++)
            {
                if (!numbers.Contains(number))
                {
                    missingNumbers.Add(number);
                }
            }
            Console.WriteLine();
            Console.WriteLine("The missing numbers are: ");
            Console.WriteLine(string.Join(", ", missingNumbers));
            Console.WriteLine();
            Console.Write(" ");

            //if i == 0 output " "

            for (int i = 0; i < 10; i++)
            {
                int min = i * 10;
                int max = min + 9;
                Console.Write($"{min}-{max}: ");

                foreach (int number in numbers)
                {
                    if (number / 10 == i)
                    {
                        Console.Write("#");
                    }
                }

                Console.WriteLine();

            }





            Console.ReadKey(true);
        }
    }
}
