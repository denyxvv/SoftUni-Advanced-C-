using System;

namespace _01._Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Username = "Pesho";
            student.Age = 20;
            student.AverageGrade = 5.50;

            Console.WriteLine(student.Username);
        }
    }
}
