﻿using System;

namespace _02.GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int item = int.Parse(Console.ReadLine());
                box.Items.Add(item);
            }

            Console.WriteLine(box);

        }
    }
}
