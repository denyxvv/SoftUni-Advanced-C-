using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> peopleOver30 = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] nameAndAge = Console.ReadLine().Split();

                Person person = new Person(nameAndAge[0], int.Parse(nameAndAge[1]));

                if (person.Age > 30)
                {
                    peopleOver30.Add(person);
                }
            }

            foreach (var person in peopleOver30.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
