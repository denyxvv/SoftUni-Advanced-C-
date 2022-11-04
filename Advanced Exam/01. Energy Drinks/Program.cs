using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Energy_Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var miligramsCaffeine = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            var energyDrinks = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            int currCaffeine = 0;
            int caffeineLimit = 300;

            while (miligramsCaffeine.Count > 0 && energyDrinks.Count > 0)
            {
                int currMiligrams = miligramsCaffeine.Pop();
                int currEnergyDrink = energyDrinks.Dequeue();

                int calc = currMiligrams * currEnergyDrink;

                if (calc <= caffeineLimit - currCaffeine)
                {
                    currCaffeine += calc;
                }
                else
                {
                    energyDrinks.Enqueue(currEnergyDrink);
                    if (currCaffeine >= 30)
                    {
                        currCaffeine -= 30;
                    }
                }
            }

            if (energyDrinks.Count > 0)
            {
                Console.WriteLine($"Drinks left: {string.Join(", ",energyDrinks)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {currCaffeine} mg caffeine.");
        }
    }
}
