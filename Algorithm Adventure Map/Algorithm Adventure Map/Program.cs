using System;
using System.Collections.Generic;

namespace Algorithm_Adventure_Map
{
    class Program
    {
        static Random random = new Random();

        static int TreePercentage(int stopX, int treeX)
        {
            double x = (double)treeX / stopX;

            double y = -Math.Pow(x, 2) + 1 + 0.05 * (Math.Cos(4 * Math.PI * Math.Pow(x, 2)) - 1);

            return (int)(y * 100);
        }

        static List<int> GenerateCurve(int currentPositionX, int startingPositionX)
        {

            //It goes from top to bottom.
            //It curves left and right.
            //It's drawn with the \|/ characters.

            //It starts at the left quarter instead of the right quarter.
            //It is 2 instead of 3 characters wide.
            //It is gray instead of blue.
            //It curves less than the river(the chance of going left or right is smaller).
            //There are turrets([]) instead of the bridge(==) next to the road.


            var curveValues = new List<int>();







            return curveValues;
        }

        static void DrawMap(int height, int width)
        {
            // Forest width
            int forestWidth = width / 4;

            // Trees characters
            var Trees = new List<string> { "T", "A", "@", "(", ")", "%" };


            // Setting the road
            var road = new bool[height, width];
            var bridge = new bool[height, width];

            var threeQuarter = width - (width / 4);
            var currentHeight = height / 2;

            int smallRoadStartY = height;


            // Generating road tiles
            for (int x = 1; x < width; x++)
            {
                if (x == 1)
                {
                    road[currentHeight, x] = true;
                    continue;
                }

                // Building the bridge
                if (width - threeQuarter <= 7)
                {
                    if (x == width - 8)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            road[currentHeight, x] = true;
                            bridge[currentHeight + 1, x] = true;
                            bridge[currentHeight - 1, x] = true;
                            x++;
                        }
                        road[currentHeight, x] = true;
                        x++;
                    }
                }
                else if (x == threeQuarter)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        road[currentHeight, x] = true;
                        bridge[currentHeight + 1, x] = true;
                        bridge[currentHeight - 1, x] = true;
                        x++;
                    }
                    road[currentHeight, x] = true;
                    x++;

                }


                // choosing direction
                int directionCheck = random.Next(5);

                // setting direction
                if (directionCheck == 1)
                {
                    // countering out of bounds
                    if (currentHeight == height - 2)
                    {
                        currentHeight--;
                    }
                    currentHeight++;
                }
                else if (directionCheck == 2)
                {
                    // countering out of bounds
                    if (currentHeight == 1)
                    {
                        currentHeight++;
                    }
                    currentHeight--;
                }

                road[currentHeight, x] = true;


            }


            // Title
            string title = "ADVENTURE MAP";
            int titleLength = title.Length;
            int titleStartX = (width - titleLength) / 2;

            // River directions
            int riverPositionX = threeQuarter + 2;
            int previousRiverDirection = 0;
            int previous2RiverDirection = 0;

            // Wall






            // Drawing the board

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Border
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    if (y == 0 && x == 0 || y == 0 && x == width - 1 || y == height - 1 && x == 0 || y == height - 1 && x == width - 1)
                    {
                        Console.Write("+");
                        continue;
                    }

                    if (y == 0 || y == height - 1)
                    {
                        Console.Write("-");
                        continue;
                    }

                    if (x == 0 || x == width - 1)
                    {
                        Console.Write("|");
                        continue;
                    }

                    // Title
                    if (y == 1 && x == titleStartX)
                    {
                        Console.Write(title);
                        x += titleLength - 1;
                        continue;
                    }



                    // Draw the road
                    if (road[y, x])
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("#");
                        continue;
                    }

                    // Draw the bridge
                    if (bridge[y, x])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("=");
                        continue;
                    }


                    //Draw the small road

                    // Check start position
                    for (int i = 0; i < height; i++)
                    {
                        if (road[i, riverPositionX - 4])
                        {
                            smallRoadStartY = i;
                        }
                    }
                    // Actually draw the thing
                    if (x == riverPositionX - 4 && y > smallRoadStartY)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("#");
                        continue;
                    }



                    //Draw the river
                    if (y > 0 && x == riverPositionX)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;

                        // Decide new direction
                        int direction = random.Next(3);

                        if (direction == 1 && riverPositionX < threeQuarter + 3 && previousRiverDirection != 2 && !(previousRiverDirection == 0 && previous2RiverDirection == 1))
                        {
                            riverPositionX++;
                        }
                        else if (direction == 2 && riverPositionX > threeQuarter && previousRiverDirection != 1 && !(previousRiverDirection == 0 && previous2RiverDirection == 2))
                        {
                            riverPositionX--;
                        }
                        else
                        {
                            direction = 0;
                        }

                        x = x + 2;

                        // what it's using:
                        //  - direction (self-contained)
                        //  - riverpositionX (current position)
                        //  - threeQuarter (= original starting position)
                        // Countering illegal turns
                        //  - previousDirection (direction in the last iteration)
                        //  - previous2Direction (direction in the second to last iteration)

                        // what it's affecting:
                        //  - riverpositionX (current position)
                        //  - x (for symbols used = symbols.length -1)

                        // values that continue:
                        //  - direction


                        // Decide which symbol to draw
                        if (direction == 0 && previousRiverDirection == 0)
                        {
                            Console.Write("|||");
                        }
                        else if (direction != 2 && previousRiverDirection != 2)
                        {
                            Console.Write(@"\\\");
                        }
                        else
                        {
                            Console.Write("///");
                        }

                        previous2RiverDirection = previousRiverDirection;
                        previousRiverDirection = direction;

                        // what it's using:
                        //  - direction
                        //  - previousDirection

                        // what it's affecting:
                        //  - which symbol to write
                        // After writing
                        //  - previous2Direction (= previousDirection)
                        //  - previousDirection (= direction)

                        continue;
                    }


                    /*
                    // Draw the wall

                    if (y > 0 && x == width / 4)
                    {
                        // Decide which symbol to draw

                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        List<int> wallStart = GenerateCurve();

                    }
                    */









                    //Decide on a tree
                    int tree = random.Next(6);


                    // Draw a tree
                    if (x < forestWidth)
                    {
                        // Decide on if tree
                        int treeChance = TreePercentage(forestWidth, x);

                        int diceRoll = random.Next(100);

                        if (diceRoll < treeChance)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(Trees[tree]);
                            continue;

                        }
                    }

                    Console.Write(" ");


                }

                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            while (true)
            {
                DrawMap(20, 80);
                Console.ReadKey(true);
                Console.SetCursorPosition(0, 0);
            }
        }
    }
}
