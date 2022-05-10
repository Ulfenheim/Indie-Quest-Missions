using System;

namespace Loops_Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            //2. Draw a measuring tape that goes from 0 to n*10 with a number displayed every 5 places.

            /*for (int i = 0; i <= n * 10; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i);

                    int digitsCount = i.ToString().Length;

                    i += digitsCount - 1;
                }
                else
                {
                    Console.Write(" ");
                }
            }
            */

            //while loop without the consistency benefit
            while (Console.CursorLeft <= n * 10)
            {
                if (Console.CursorLeft % 5 == 0)
                {
                    Console.Write(Console.CursorLeft);
                }
                else
                {
                    Console.Write(" ");
                }
            }

            //let's pretend this is a while loop
            Console.WriteLine();
            for (int i = 0; i <= n * 10; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write("_");
                }
            }
            Console.WriteLine();


            //super mega condense!
            /*

            for (int row = 0; row < 2; row++)
            {
                while (Console.CursorLeft <= n * 10)
                {
                    if (Console.CursorLeft % 5 == 0)
                    {
                        Console.Write(row == 0 ? Console.CursorLeft.ToString() : "|");
                    }
                    else
                    {
                        Console.Write(row == 0 ? " " : "_");
                    }
                }
                Console.WriteLine();
            }
            */

            Console.WriteLine();
            Console.WriteLine();


            //3. Draw a castle with n guard towers and a gate in the middle.

            for (int i = 0; i < n; i++)
            {
                Console.Write("[^^^] ");
            }

            Console.WriteLine();

            Console.Write(" | |__");

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("_| |__");
            }

            Console.Write("_| |");

            Console.WriteLine();

            Console.Write(" |");

            int castleWidth = 6 * n - 1;
            int innerWidth = castleWidth - 4;
            int innerSpaces = innerWidth - 3;
            int sideSpaces = innerSpaces / 2;

            /*
            for (int i = 0; i < sideSpaces; i++)
            {
                Console.Write(" ");
            }

            Console.Write(@"/|\");

            for (int i = 0; i < sideSpaces; i++)
            {
                Console.Write(" ");
            }
            */

            Console.Write(@"/|\".PadLeft(sideSpaces + 3).PadRight(innerWidth));

            Console.Write("| ");
            Console.WriteLine();

            Console.Write(" |");

            Console.Write("|||".PadLeft(sideSpaces + 3, '_').PadRight(innerWidth, '_'));

            Console.Write("| ");

            Console.WriteLine();
            Console.WriteLine();

            //4. Draw the last digit of n (n % 10) as if it was shown on an LCD display (made out of 7 lines).


            //the ugliest piece of code Matej has ever seen. We've made him proud.

            // int d = n % 10;

            for (int d = 0; d < 10; d++)
            {
                Console.Write(" ");
                Console.WriteLine(!(d == 1 || d == 4) ? "_" : " ");
                Console.Write(!(d >= 1 && d <= 3 || d == 7) ? "|" : " ");
                Console.Write(!(d <= 1 || d == 7) ? "_" : " ");
                Console.WriteLine(!(d == 5 || d == 6) ? "|" : " ");
                Console.Write(d % 2 == 0 && d != 4 ? "|" : " ");
                Console.Write(!(d == 1 || d == 4 || d == 7) ? "_" : " ");
                Console.WriteLine(d != 2 ? "|" : " ");

            }
            Console.WriteLine();

            // Console.Write(!() ? "_" : " ");

            Console.WriteLine();
            Console.WriteLine();




            Console.ReadKey(true);
        }
    }
}
