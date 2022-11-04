using System;

namespace _01.BoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                box.Items.Add(item);
            }

            Console.WriteLine(box);

        }
    }
}
