using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(", ");
                string direction = tokens[0];
                string PlateNumber = tokens[1];

                switch (direction)
                {
                    case "IN":
                        cars.Add(PlateNumber);
                        break;
                    case "OUT":
                        cars.Remove(PlateNumber);
                        break;
                }
                command = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
