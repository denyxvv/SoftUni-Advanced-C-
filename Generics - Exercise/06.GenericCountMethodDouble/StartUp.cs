﻿using System;
using System.Linq;
using _01.BoxOfString;

namespace _02.GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double item = double.Parse(Console.ReadLine());

                box.Items.Add(item);
            }

            double itemToCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Count(itemToCompare));

        }
    }
}
