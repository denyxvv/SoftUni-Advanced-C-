using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsInfo = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(songsInfo);

            while (songs.Count > 0)
            {
                string[] command = Console.ReadLine().Split();
                string cmdType = command[0];
                switch (cmdType)
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string songToAdd = string.Join(" ", command.Skip(1));

                        if (songs.Contains(songToAdd))
                        {
                            Console.WriteLine($"{songToAdd} is already contained!");
                            continue;
                        }
                        
                            songs.Enqueue(songToAdd);
                        

                        break;
                    case "Show":
                        Console.WriteLine(String.Join(", ", songs));
                        break;

                }
            }

            Console.WriteLine($"No more songs!");
        }
    }
}
