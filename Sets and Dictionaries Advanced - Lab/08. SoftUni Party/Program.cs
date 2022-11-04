using System;
using System.Collections.Generic;
using System.Data;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> Regular = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "PARTY")
            {
                var firstChar = command[0];
                if (char.IsDigit(firstChar))
                {
                    VIP.Add(command);
                }
                else
                {
                    Regular.Add(command);
                }
                command = Console.ReadLine();
            }

            while (command != "END")
            {
                VIP.Remove(command);
                Regular.Remove(command);

                command = Console.ReadLine();
            }

            Console.WriteLine(VIP.Count + Regular.Count);

            foreach (var client in VIP)
            {
                Console.WriteLine(client);
            }
            foreach (var client in Regular)
            {
                Console.WriteLine(client);
            }
        }
    }
}
