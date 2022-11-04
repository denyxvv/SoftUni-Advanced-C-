//You should start from the first water and mix it with the last flour. If the ratio of water/flour corresponds to some of the following bakery products:

//•	Croissant – consists of 50% water and 50% flour
//•	Muffin – consists of 40% water and 60% flour
//•	Baguette – consists of 30% water and 70% flour
//•	Bagel – consists of 20% water and 80% flour 

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        /*
        16.8 32.4 19.5 25
        15 30 45.5 48.6 25.2
         */
        static void Main(string[] args)
        {
            var bekaryResult = new Dictionary<string, int>
            {
                {"Croissant", 0 },
                {"Muffin", 0 },
                {"Baguette", 0 },
                {"Bagel", 0 }
            };

            Queue<double> water =
                new Queue<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray());

            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray());

            while (water.Any() && flour.Any())
            {
                var firstWater = water.Peek();
                var lastFlour = flour.Peek();

                double calc = firstWater + lastFlour;
                double waterPercent = (firstWater * 100) / calc;

                if (waterPercent == 50)
                {
                    bekaryResult["Croissant"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if (waterPercent == 40)
                {
                    bekaryResult["Muffin"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if (waterPercent == 30)
                {
                    bekaryResult["Baguette"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if (waterPercent == 20)
                {
                    bekaryResult["Bagel"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else
                {
                    var currWater = water.Dequeue();
                    var currFlour = flour.Pop();
                    var flourReduced = currFlour - currWater;
                    bekaryResult["Croissant"]++;
                    flour.Push(flourReduced);
                }
            }

            foreach (var product in bekaryResult.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (product.Value > 0)
                {
                    Console.WriteLine($"{product.Key}: {product.Value}");
                }

            }

            if (water.Count == 0)
            {
                Console.WriteLine($"Water left: None");
            }
            else
            {
                Console.Write("Water left: ");
                Console.WriteLine(string.Join(", ", water));
            }

            if (flour.Count == 0)
            {
                Console.WriteLine($"Flour left: None");
            }
            else
            {
                Console.Write("Flour left: ");
                Console.Write(string.Join(", ", flour));
            }

            Console.WriteLine();

        }
    }

}
