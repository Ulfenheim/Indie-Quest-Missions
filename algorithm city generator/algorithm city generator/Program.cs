using System;

namespace algorithm_city_generator
{
    class Program
    {
        static Random random = new Random();

        static void GenerateRoad(bool[,] roads, int startX, int startY, int direction)
        {
            int height = roads.GetLength(1);
            int width = roads.GetLength(0);

            if (direction == 0)
            {
                for (int x = startX; x < width; x++)
                {
                    roads[x, startY] = true;
                }
            }
            else if (direction == 1)
            {
                for (int y = startY; y < height; y++)
                {
                    roads[startX, y] = true;
                }
            }
            else if (direction == 2)
            {
                for (int x = startX; x >= 0; x--)
                {
                    roads[x, startY] = true;
                }
            }
            else
            {
                for (int y = startY; y >= 0; y--)
                {
                    roads[startX, y] = true;
                }
            }

        }

        static void GenerateIntersection(bool[,] roads, int x, int y)
        {
            //In other words, the GenerateIntersection method will go over all 4 directions with a 70% chance it will call GenerateRoad into that direction from the intersection coordinates.

            for (int direction = 0; direction < 4; direction++)
            {
                int check = random.Next(10);

                if (check < 7)
                {
                    GenerateRoad(roads, x, y, direction);
                }
            }
        }


        static void Main(string[] args)
        {

            //prepare roads/map
            int width = 40;
            int height = 20;
            var roads = new bool[width, height];

            //create shit tons of random intersections
            for (int i = 0; i < 3; i++)
            {
                int startX = random.Next(width);
                int startY = random.Next(height);
                GenerateIntersection(roads, startX, startY);
            }

            //draw the map
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (roads[x, y])
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





            Console.ReadKey(true);

        }
    }
}
