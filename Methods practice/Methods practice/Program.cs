using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods_practice
{
    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int SafeDivision(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                return x / y;
            }
        }

        static double AreaofCircle(double x)
        {

            double area = Math.PI * x * x;
            return area;

        }

        static int MaximumInteger(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        static int AddIntegers(List<int> numbers)
        {
            int sum = numbers.Sum();
            return sum;
        }

        static int SmallestOfIntegers(List<int> numbers)
        {
            int minValue = numbers.Min();
            return minValue;
        }

        static List<int> SortIntegersDescending(List<int> numbers)
        {
            numbers.Sort();
            numbers.Reverse();

            return numbers;
        }


        static List<int> UniqueIntegers(List<int> numbers)
        {

            // Max's brilliant idea to sort the list before the code that solved this whole thing
            numbers.Sort();

            int compareIndex = 0;

            while (compareIndex < numbers.Count - 1)
            {
                if (numbers[compareIndex] == numbers[compareIndex + 1])
                {
                    numbers.Remove(numbers[compareIndex]);
                }
                else
                {
                    compareIndex++;
                }
            }

            return numbers;
        }


        static List<int> JoinIntegers(List<int> first, List<int> second)
        {
            var combined = new List<int> { };

            for (int i = 0; i < first.Count; i++)
            {
                combined.Add(first[i]);
            }

            for (int i = 0; i < second.Count; i++)
            {
                combined.Add(second[i]);
            }

            return combined;
        }


        static List<int> CreateRandomIntegers(int count, int minimum, int maximum)
        {
            var result = new List<int> { };

            var random = new Random();

            for (int i = 0; i <= count-1; i++)
            {
                int diceroll = 0;
                diceroll = random.Next(minimum, maximum + 1);
                result.Add(diceroll);
            }

            return result;
        }


        static void Indent(string text, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(text);
        }


        static List<string> CreateFullNames(List<string> first, List<string> second)
        {
            var fullNames = new List<string> { };
            string space = " ";

            for (int i = 0; i < first.Count; i++)
            {
                var name = string.Concat(first[i], space, second[i]);
                fullNames.Add(name);
            }

            return fullNames;
        }



        static List<string> ZipStrings(List<string> first, List<string> second)
        {
            var joinedList = new List<string> { };

            if (first.Count == second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    joinedList.Add(first[i]);
                    joinedList.Add(second[i]);
                }
            }
            else if (first.Count < second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    joinedList.Add(first[i]);
                    joinedList.Add(second[i]);
                }

                for (int i = first.Count; i < second.Count; i++)
                {
                    joinedList.Add(second[i]);
                }

            }
            else
            {
                for (int i = 0; i < second.Count; i++)
                {
                    joinedList.Add(first[i]);
                    joinedList.Add(second[i]);
                }

                for (int i = second.Count; i < first.Count; i++)
                {
                    joinedList.Add(first[i]);
                }
            }

            return joinedList;
        }



        static int CountStrings(string searchValue, List<string> stringList)
        {
            int occuranceCount = 0;

            foreach (string name in stringList)
            {
                if (name == searchValue)
                {
                    occuranceCount++;
                }
            }
            return occuranceCount;
        }





        // -------------------- //

        static void Main(string[] args)
        {
            //1. Write a method Add that accepts two integers and returns their sum.
            int AddI = Add(1, 4);
            Console.WriteLine(AddI);
            Console.WriteLine();

            //2. Write a method SafeDivision that accepts two integers (dividend, divisor). If the divisor is 0, it returns the dividend. Otherwise it returns the quotient of the integer division.
            int SafeDivisionI = SafeDivision(10, 2);
            Console.WriteLine(SafeDivisionI);
            SafeDivisionI = SafeDivision(10, 0);
            Console.WriteLine(SafeDivisionI);
            Console.WriteLine();

            //3. Write a method AreaOfCircle that accepts a double radius and returns the area of a circle with that radius.
            double area = AreaofCircle(5);
            Console.WriteLine(area);
            Console.WriteLine();

            //4. Write a method MaximumInteger that accepts two integers and returns the bigger one of them.
            int largest = MaximumInteger(1, 4);
            Console.WriteLine($"The largest of 1 and 4 is {largest}.");
            Console.WriteLine();

            //5. Write a method AddIntegers that accepts a list of integers and returns the sum of all items in the list.
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.Write("The sum of the integers ");
            Console.Write(string.Join(", ", numbers));
            Console.Write(" is ");
            Console.Write(AddIntegers(numbers));
            Console.WriteLine(".");
            Console.WriteLine();

            //6. Write a method SmallestOfIntegers that accepts a list of integers and returns the smallest of them.
            var numbers2 = new List<int> { 3, -2, 7, 0, 10 };
            Console.Write("The smallest of integers ");
            Console.Write(string.Join(", ", numbers2));
            Console.Write(" is ");
            Console.Write(SmallestOfIntegers(numbers2));
            Console.WriteLine(".");
            Console.WriteLine();

            //7. Write a method SortIntegersDescending that accepts a list of integers and sorts the list from highest to lowest number.
            SortIntegersDescending(numbers2);
            Console.Write("These numbers in descending order are ");
            Console.Write(string.Join(", ", numbers2));
            Console.WriteLine(".");
            Console.WriteLine();


            //8. Write a method UniqueIntegers that accepts a list of integers and returns a new list with any duplicates removed.
            var uniqueNumbers = new List<int> { 10, 3, 10, 2, 0, 2 };
            Console.Write("Among the integers [ ");
            Console.Write(string.Join(", ", uniqueNumbers));
            Console.Write(" ] the unique ones are ");
            UniqueIntegers(uniqueNumbers);
            Console.WriteLine(string.Join(", ", uniqueNumbers));
            Console.WriteLine();


            //9. Write a method JoinIntegers that accepts two lists of integers and returns a new list with integers from the first list, followed by the integers from the second list.
            var joinIntegers = new List<int> { 1, 2, 3 };
            var joinIntegers2 = new List<int> { 7, 8, 9 };

            Console.Write("Joined together, the lists [");
            Console.Write(string.Join(", ", joinIntegers));
            Console.Write("] and [");
            Console.Write(string.Join(", ", joinIntegers2));
            Console.Write("] become ");
            Console.Write(string.Join(", ", JoinIntegers(joinIntegers, joinIntegers2)));
            Console.WriteLine(".");
            Console.WriteLine();


            //10. Write a method CreateRandomIntegers that accepts three integers (count, minimum, maximum) and returns a list with count random integers between minimum and maximum (both inclusive).
            Console.Write("The following is a list of 10 random numbers between -2 and 2. [");
            Console.Write(string.Join(", ", CreateRandomIntegers(10, -2, 2)));
            Console.WriteLine("]");
            Console.WriteLine();


            //11. Write a method Indent that accepts a string text and integer count. It returns text with count spaces added to the start.
            Indent("I am indented by 0 spaces.", 0);
            Indent("I am indented by 7 spaces.", 7);
            Indent("I am indented by 1 space.", 1);
            Console.WriteLine();


            //12. Write a method CreateFullNames that accepts two equally-long lists of strings (firstNames, lastNames) and returns a list of full names (first and last names concatenated by a space at their respective indices).
            var first = new List<string> { "Spyro", "Crash", "Sonic" };
            var second = new List<string> { "the Dragon", "Bandicoot", "the Hedgehog" };
            Console.Write("We join the names [");
            Console.Write(string.Join(", ", first));
            Console.Write("] with [");
            Console.Write(string.Join(", ", second));
            Console.Write("] to get ");
            Console.WriteLine(string.Join(", ", CreateFullNames(first, second)));
            Console.WriteLine();

            //13. Write a method ZipStrings that accepts two lists of strings (possibly of unequal counts) and returns a new list with strings alternating between each of the lists.
            var firstNames = new List<string> { "Spyro", "Crash", "Sonic", "Morrigan" };
            var secondNames = new List<string> { "Tormund", "Bilbo", "Link", "Alistair", "Zelda", "Midna" };
            Console.WriteLine(string.Join(", ", ZipStrings(firstNames, secondNames)));
            Console.WriteLine();


            //14. Write a method CountStrings that accepts a string searchValue and a list of strings. It returns the number of occurrences of searchString in the list.
            var commandList = new List<string> { "ADD", "DEL", "INC", "ADD", "JMP", "SUB", "DEC" };
            Console.Write("The command ADD appears ");
            Console.Write(CountStrings("ADD", commandList));
            Console.Write(" times in the program [");
            Console.Write(string.Join(", ", commandList));
            Console.WriteLine("]");










            // -------------------- //

            Console.ReadKey(true);
        }
    }
}
