using System;


namespace Loops_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int n = 5;

            //2. Draw a line n long.
            for (int i = 0; i < n; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            Console.WriteLine();


            //3. Draw a square with side n.
            for (int i = 0; i < n; i++)
            {
                for (int ii = 0; ii < n; ii++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //4. Draw a right triangle with legs size n.
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //5. Draw a parallelogram with height n.

            for (int i = 0; i < n; i++)
            {
                for (int d = 0; d < n - i; d++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < n; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //6. Draw an Isosceles triangle with height n and base 2n-1.

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            //7. Draw a square with side n with every other row blank.

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

                /*
                for (int i = 0; i < n; i++)
                {
                    Console.Write(" ");
                }
                */

                Console.WriteLine();
            }

            if (n % 2 == 1)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
            Console.WriteLine();


            //8. Draw a square with side n with every other column blank.

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /*
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    Console.Write("#");
                    Console.Write(" ");
                }

                if (n % 2 == 1)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            */




            //9. Draw a grid with side n with a line on every other row and every other column.

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 1 && j % 2 == 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            /*
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

                for (int y = 0; y < n / 2; y++)
                {
                    Console.Write("#");
                    Console.Write(" ");
                }

                if (n % 2 == 1)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            if (n % 2 == 1)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            */




            //10. Draw a fence with side n with a line on every other row and every other column.

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            /*
           for (int i = 0; i < n / 2; i++)
           {
               for (int y = 0; y < n / 2; y++)
               {
                   Console.Write(" ");
                   Console.Write("#");
               }
               Console.WriteLine();

               for (int j = 0; j < n; j++)
               {
                   Console.Write("#");
               }
               Console.WriteLine();

           }

           if (n % 2 == 1)
           {
               for (int y = 0; y < n / 2; y++)
               {
                   Console.Write(" ");
                   Console.Write("#");
               }
           }
           Console.WriteLine();
           Console.WriteLine();
            */



            //11. Draw a chessboard with side n.

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == j % 2)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            /*
           for (int i = 0; i < n / 2; i++)
           {
               for (int j = 0; j < n / 2; j++)
               {
                   Console.Write("#");
                   Console.Write(" ");
               }

               if (n % 2 == 1)
               {
                   Console.Write("#");
               }

               Console.WriteLine();

               for (int y = 0; y < n / 2; y++)
               {
                   Console.Write(" ");
                   Console.Write("#");
               }
               Console.WriteLine();
           }

           if (n % 2 == 1)
           {
               for (int j = 0; j < n / 2; j++)
               {
                   Console.Write("#");
                   Console.Write(" ");
               }

               if (n % 2 == 1)
               {
                   Console.Write("#");
               }

           }
           Console.WriteLine();
           Console.WriteLine();
           */

            /*
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0 || i % 2 == 1 && j % 2 == 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            */



            //Time to clear the board
            Console.Clear();


            //12. Draw a slope that starts 1 wide and doubles the width in each row. Keep drawing while the width is less than 80.

            for (int i = 1; i < 81; i *= 2)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //13. Draw a reverse slope that starts at width 40 and decreases by n in every row.

            for (int i = 40; i > 0; i -= n)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //14. Draw a cliff that starts with a rectangle n wide and 1 tall. Next rectangle is 1 block narrower and 1 block taller (n-1 by 2). Continue until you draw a rectangle 1 wide and n tall.

            //loop turns
            for (int i = n; i > 0; i--)
            {
                //height
                for (int y = 0; y < n - i + 1; y++)
                {
                    //width
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();


            //15. Draw a set of lines. In the first row, the first line is n long, the next is one shorter and so on until you draw a line 1 long. In the next row, everything repeats except you start with the line that is n-1 long. Continue adding rows until only the line with length 1 is drawn on it.

            //number of loops (height)
            for (int i = n; i > 0; i--)
            {
                //side rows
                for (int k = i; k > 0; k--)
                {
                    //number of symbols
                    for (int y = 0; y < k; y++)
                    {
                        Console.Write("#");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }



            Console.ReadKey(true);
        }
    }
}
