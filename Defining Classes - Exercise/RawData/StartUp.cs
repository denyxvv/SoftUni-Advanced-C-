using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                
                Car car = new Car(
                    tokens[0], 
                    int.Parse(tokens[1]),
                    int.Parse(tokens[2]),
                    int.Parse(tokens[3]),
                    tokens[4],
                    double.Parse(tokens[5]),
                    int.Parse(tokens[6]),
                    double.Parse(tokens[7]),
                    int.Parse(tokens[8]),
                    double.Parse(tokens[9]),
                    int.Parse(tokens[10]),
                    double.Parse(tokens[11]),
                    int.Parse(tokens[12])
                    );

                cars.Add(car);

                string command = Console.ReadLine();
                string[] filteredCarModels;

                if (command == "fragile")
                {
                    filteredCarModels = cars
                        .Where(x => x.Cargo.Type == "fragile" && car.Tires.Any(x => x.Pressure < 1))
                        .Select(x => x.Model)
                        .ToArray();
                }
                else
                {
                    filteredCarModels = cars
                        .Where(x => x.Cargo.Type == "flammable" && car.Engine.Power > 250)
                        .Select(x => x.Model)
                        .ToArray();
                }

                foreach (var carModel in filteredCarModels)
                {
                    Console.WriteLine(carModel);
                }
            }
        }
    }
}
