﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _09._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();
            while (command != "Party!")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];

                if (action == "Remove")
                {
                    people.RemoveAll(GetPredicate(filter, value));
                }
                else
                {
                    List<string> peopleToDouble = people.FindAll(GetPredicate(filter, value));

                    int index = people.FindIndex(GetPredicate(filter, value));
                    if (index >= 0)
                    {
                        people.InsertRange(index, peopleToDouble);
                    }
                }

                command = Console.ReadLine();
            }

            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ",people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string filter, string value)
        {
            switch (filter)
            {
                case "StartsWith":
                    return s => s.StartsWith(value);
                case "EndsWith":
                    return s => s.EndsWith(value);
                case "Lenght":
                    return s => s.Length == int.Parse(value);
                default:
                    return default(Predicate<string>);
            }
        }
    }
}
