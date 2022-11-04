using System;
using _02._Car_Extension;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "BMW",
                Model = "x3",
                Year = 2006,
                FuelConsumption = 0.3,
                FuelQuantity = 100
            };

            while (true)
            {
                Console.WriteLine("where to go ?");
                car.Drive(int.Parse(Console.ReadLine()));
                Console.WriteLine(car.WhoAmI());
                
            }
        }
    }
}
