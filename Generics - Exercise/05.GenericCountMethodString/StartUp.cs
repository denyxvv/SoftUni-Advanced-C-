using System;
using System.Linq;
using _01.BoxOfString;

namespace _02.GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();

                box.Items.Add(item);
            }

            string itemToCompare = Console.ReadLine();
            Console.WriteLine(box.Count(itemToCompare));

        }
    }
}
