using System;
using System.Collections.Generic;

namespace algorithms_3
{
    class Program
    {


        static string OrdinalNumber(int number)
        {
            int lastDigit = number % 10;
            int firstDigit = number / 10 % 10;


            if (firstDigit == 1)
            {
                return number + "th";
            }
            else if (lastDigit == 1)
            {
                return number + "st";
            }
            else if (lastDigit == 2)
            {
                return number + "nd";
            }
            else if (lastDigit == 3)
            {
                return number + "rd";
            }
            else
            {
                return number + "th";
            }
        }


        // Get the last digit of an integer by modding it with 10.
        // If the number is bigger than 10, also get the second to last digit by dividing the integer by 10 and then modding the result with 10.
        // If the second to last digit is 1, return the integer plus "th"
        // If the last digit is 1, return the integer plus "st".
        // If the last digit is 2, return the integer plus "nd".
        // If the last digit is 3, return the integer plus "rd".
        // Otherwise return integer plus "th".




        static void Main(string[] args)
        {
            var random = new Random();
            var generatedNumbers = new List<int> { };

            for (int i = 0; i < 10; i++)
            {
                int number = random.Next(0, 151);
                generatedNumbers.Add(number);
            }
            generatedNumbers.Sort();

            Console.WriteLine(OrdinalNumber(generatedNumbers[0]));
            Console.WriteLine(OrdinalNumber(generatedNumbers[1]));
            Console.WriteLine(OrdinalNumber(generatedNumbers[2]));
            Console.WriteLine(OrdinalNumber(generatedNumbers[3]));
            Console.WriteLine(OrdinalNumber(generatedNumbers[4]));
            Console.WriteLine(OrdinalNumber(generatedNumbers[5]));
            Console.WriteLine(OrdinalNumber(generatedNumbers[6]));
            Console.WriteLine(OrdinalNumber(generatedNumbers[7]));
            Console.WriteLine(OrdinalNumber(generatedNumbers[8]));
            Console.WriteLine(OrdinalNumber(generatedNumbers[9]));








            //Getting the last and first digits of an integer
            /*
            int i = 15;

            //get the last digit of an integer
            int lastDigit = i % 10;
            Console.WriteLine(lastDigit);

            //get the first digit if the number is larger than ten
            int firstDigit = i / 10 % 10;
            Console.WriteLine(firstDigit);
            */



            Console.ReadKey(true);

        }
    }
}
