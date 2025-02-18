﻿using System;
using System.Linq;
using _01.BoxOfString;

namespace _02.GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int item = int.Parse(Console.ReadLine());

                box.Items.Add(item);
            }

            int[] indices = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            box.Swap(indices[0], indices[1]);

            Console.WriteLine(box);

        }
    }
}
