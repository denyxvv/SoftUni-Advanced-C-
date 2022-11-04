using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothesByColor =
                new Dictionary<string, Dictionary<string, int>>();
                
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string colour = tokens[0];

                if (!clothesByColor.ContainsKey(colour))
                {
                    clothesByColor[colour] = new Dictionary<string, int>();
                }

                for (int j = 1; j < tokens.Length; j++)
                {
                    string currClothing = tokens[j];

                    if (!clothesByColor[colour].ContainsKey(currClothing))
                    {
                        clothesByColor[colour].Add(currClothing, 0);
                    }

                    clothesByColor[colour][tokens[j]]++;
                }
            }

            string[] findParams = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var colour in clothesByColor)
            {
                Console.WriteLine($"{colour.Key} clothes:");
                foreach (var clothing in colour.Value)
                {
                    string printItem = $"* {clothing.Key} - {clothing.Value}";
                    if (colour.Key == findParams[0] && clothing.Key == findParams[1])
                    {
                        printItem += " (found!)";
                    }

                    Console.WriteLine(printItem);
                }
            }
        }
    }
}
