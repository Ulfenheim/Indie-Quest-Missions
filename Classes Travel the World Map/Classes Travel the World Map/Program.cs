using System;
using System.Collections.Generic;
using System.Threading;

namespace Classes_Travel_the_World_Map
{

    class Location
    {
        public string Name;
        public string Description;
        public List<Location> Neighbors = new List<Location>();
    }


    class Program
    {
        static int travelCounter = 0;
        static Random random = new Random();

        static void ConnectLocations(Location a, Location b)
        {
            a.Neighbors.Add(b);
            b.Neighbors.Add(a);
        }



        static Location GoToLocation(Location currentLocation)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to {currentLocation.Name}, {currentLocation.Description}.");
            Console.WriteLine();

            Console.WriteLine("Possible destinations are:");

            for (int i = 0; i < currentLocation.Neighbors.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {currentLocation.Neighbors[i].Name}");
            }

            Console.WriteLine();
            Console.WriteLine("Where do you want to travel?");
            string playerInput = Console.ReadLine();
            int neighbourIndex = Int32.Parse(playerInput) - 1;

            //int neighbourIndex = random.Next(currentLocation.Neighbors.Count);

            Location selectedNeighbor = currentLocation.Neighbors[neighbourIndex];

            return selectedNeighbor;


            //The mess we built for the joy of looping endlessly
            //travelCounter++;
            //Console.WriteLine($"You have traveled {travelCounter} times.");
            //Thread.Sleep(5);

            //The repeat that made the method loop just about 7996 times before Stack Overflow
            // GoToLocation(selectedNeighbor);
        }


        static void Main(string[] args)
        {
            //location Winterfell = new Location
            var winterfell = new Location
            {
                Name = "Winterfell",
                Description = "the capital of the Kingdom of the North",
            };

            var pyke = new Location
            {
                Name = "Pyke",
                Description = "the stronghold and seat of House Greyjoy",
            };

            var riverrun = new Location
            {
                Name = "Riverrun",
                Description = "a large castle located in the central-western part of the Riverlands"
            };

            var trident = new Location
            {
                Name = "The Trident",
                Description = "one of the largest and most well-known rivers on the continent of Westeros"
            };

            var kingsLanding = new Location
            {
                Name = "King's Landing",
                Description = "the capital, and largest city, of the Seven Kingdoms"
            };

            var highgarden = new Location
            {
                Name = "Highgarden",
                Description = "the seat of House Tyrell and the regional capital of the Reach"
            };

            //Riverrun neighbors
            ConnectLocations(riverrun, trident);
            ConnectLocations(riverrun, kingsLanding);
            ConnectLocations(riverrun, highgarden);
            ConnectLocations(riverrun, pyke);

            //Pyke neighbors
            ConnectLocations(pyke, winterfell);

            //winterfell
            ConnectLocations(winterfell, trident);

            //trident
            ConnectLocations(trident, kingsLanding);

            //king's landing
            ConnectLocations(kingsLanding, highgarden);

            //highgarden
            ConnectLocations(highgarden, pyke);





            //Display current location

            //GoToLocation(riverrun);

            var currentLocation = winterfell;
            for (int i = 0; i < 50; i++)
            {
                currentLocation = GoToLocation(currentLocation);
            }
            







            /*
            Console.WriteLine($"Welcome to {currentLocation.Name}, {currentLocation.Description}.");
            Console.WriteLine();

            Console.WriteLine("Possible destinations are:");

            for (int i = 0; i < currentLocation.Neighbors.Count; i++)
            {
                Console.WriteLine($"{i+1}. {currentLocation.Neighbors[i].Name}");
            }

            Console.WriteLine();
            Console.WriteLine("Where do you want to travel?");
            string playerInput = Console.ReadLine();
            int neighbourIndex = Int32.Parse(playerInput) - 1;

            Location selectedNeighbor = currentLocation.Neighbors[neighbourIndex];
            currentLocation = selectedNeighbor;
            */

            /*
            Console.WriteLine($"{riverrun.Name}");
            Console.WriteLine($"{riverrun.Description}");
            Console.WriteLine($"{riverrun.Neighbors[0].Name}");
            Console.WriteLine($"{riverrun.Neighbors[0].Neighbors[0].Name}");
            Console.WriteLine($"{currentLocation.Neighbors[0].Name}");
            Console.WriteLine($"{currentLocation.Neighbors[neighbourIndex].Name}");

            string nameOfSelectedNeighbor = currentLocation.Neighbors[neighbourIndex].Name;
            */





            Console.ReadKey(true);
        }
    }
}
