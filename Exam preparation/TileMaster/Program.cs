using System;
using System.Collections.Generic;
using System.Linq;
////
//// Location	 /    area needed
//     Sink               40
//     Oven               50
//     Countertop         60
//     Wall               70
// floor - if it doesnt match

namespace TileMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             35 16 30 3 25 9 20
             20 9 25 3 30 16 35 
            */

            Stack<int> whites = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            Queue<int> greys = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            Dictionary<string, int> locations = new Dictionary<string, int>()
            {
                { "Sink", 40 },
                { "Oven", 50 },
                { "Countertop", 60 },
                { "Wall", 70 },
            };

            Dictionary<string, int> possibleLocations = new Dictionary<string, int>()
            {
                {"Sink", 0},
                {"Oven", 0},
                {"Countertop", 0},
                {"Wall", 0},
                {"Floor", 0}
            };

            while (whites.Count != 0 && greys.Count != 0)
            {
                int white = whites.Pop();
                int grey = greys.Dequeue();
                //Console.WriteLine($"{white} + {grey} = {white + grey}");

                if (white == grey)
                {
                    int newTile = white + grey;

                    KeyValuePair<string, int> possibleLocation = locations.FirstOrDefault(x => x.Value == newTile);

                    if (possibleLocation.Key != null)
                    {
                        possibleLocations[possibleLocation.Key]++;
                    }
                    else
                    {
                        possibleLocations["Floor"]++;
                    }
                }
                else
                {
                    whites.Push(white / 2);
                    greys.Enqueue(grey);
                }
            }

            string whitesLeft = whites.Count == 0 ? "none" : string.Join(", ", whites);
            string greysLeft = greys.Count == 0 ? "none" : string.Join(", ", greys);

            Console.WriteLine($"White tiles left: {whitesLeft}");
            Console.WriteLine($"White tiles left: {greysLeft}");

            possibleLocations = possibleLocations.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(l=> l.Key, l => l.Value);

            foreach (var location in possibleLocations)
            {
                if (location.Value != 0)
                {
                    Console.WriteLine($"{location.Key}: {location.Value}");
                }
            }
        }
    }
}
