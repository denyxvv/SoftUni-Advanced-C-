/*
e a u o
p r l x f
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Food_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<char>> words = new Dictionary<string, HashSet<char>>
            {
                {
                    "pear", new HashSet<char>()
                },
                {
                    "flour", new HashSet<char>()
                },
                {
                    "pork", new HashSet<char>()
                },
                {
                    "olive", new HashSet<char>()
                }
            };

            Queue<char> vowels = new Queue<char>(string.Join
                    ("", Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)));

            Stack<char> constants = new Stack<char>(string.Join
            ("", Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)));

            while (constants.Count > 0)
            {
                char vowel = vowels.Dequeue();
                char constant = constants.Pop();
                foreach (var word in words)
                {
                    if (word.Key.Contains(vowel))
                    {
                        word.Value.Add(vowel);
                    }
                    if (word.Key.Contains(constant))
                    {
                        word.Value.Add(constant);
                    }
                }
                vowels.Enqueue(vowel);
            }

            List<string> foundWords = words.Where(x => x.Key.Count() == x.Value.Count).Select(x => x.Key).ToList();

            Console.WriteLine($"Words found: {foundWords.Count}");
            foreach (var word in foundWords)
            {
                Console.WriteLine(word);
            }

        }
    }
}
