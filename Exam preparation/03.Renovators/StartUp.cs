﻿using System;

namespace Renovators
{
    public class StartUp
    {
        static void Main()
        {
            // Initialize the repository (Catalog)
            Catalog catalog = new Catalog("Quality renovators", 5, "Kitchen");

            // Initialize entity
            Renovator renovator = new Renovator("Gosho", "Painter", 270, 7);

            //Print Renovator
            Console.WriteLine(renovator);
            /*
            -Renovator: Gosho
            --Specialty: Painter
            --Rate per day: 270 BGN 
            */

            // Add Renovator
            Console.WriteLine(catalog.AddRenovator(renovator)); // Successfully added Gosho to the catalog.
            Console.WriteLine(catalog.Count); // 1

            // Remove Renovator
            Console.WriteLine(catalog.RemoveRenovator("Pesho"));  // False

            Renovator secondRenovator = new Renovator("Pesho", "Tiles", 200, 9);
            Renovator thirdRenovator = new Renovator("Ivan", "Tiles", 450, 7);
            Renovator fourthRenovator = new Renovator("Velichko", "Painter", 120, 3);
            Renovator fifthRenovator = new Renovator("Stamat", "Furniture", 300, 4);
            Renovator sixthRenovator = new Renovator("Genadi", "Furniture", 80, 15);
            Renovator seventhRenovator = new Renovator("Unufri", "Furniture", 80, 15);


            // Add Renovators
            Console.WriteLine(catalog.AddRenovator(secondRenovator)); // Successfully added Pesho to the catalog.
            Console.WriteLine(catalog.AddRenovator(thirdRenovator)); // Invalid renovator's rate. 
            Console.WriteLine(catalog.AddRenovator(fourthRenovator)); // Successfully added Velichko to the catalog. 
            Console.WriteLine(catalog.AddRenovator(fifthRenovator)); // Successfully added Stamat to the catalog.

        }
    }
}
