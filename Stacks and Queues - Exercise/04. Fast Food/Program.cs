using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] ordersInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(ordersInfo.Max());
            Queue<int> orders = new Queue<int>(ordersInfo);

            while (orders.Count > 0)
            {
                if (orders.Peek() > quantityFood)
                {
                    break;
                }
                quantityFood -= orders.Dequeue();
                

            }
                if (orders.Count == 0)
                {
                    Console.WriteLine($"Orders complete");
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                }

        }
    }
}
