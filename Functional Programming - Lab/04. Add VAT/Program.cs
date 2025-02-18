﻿using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, string> addVAT = x => (x * 1.2M).ToString("F2");

            Console.WriteLine(string.Join(Environment.NewLine,
            Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).Select(addVAT)));
        }
    }
}
