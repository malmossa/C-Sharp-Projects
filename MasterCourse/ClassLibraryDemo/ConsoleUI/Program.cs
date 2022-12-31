using System;
using DemoLibrary;
using DemoLibrary.Models;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            person.FirstName = "Mansor";
            person.LastName = "Almossa";

            double add = Calculation.Add(2.00, 1.00);

            Console.WriteLine(add);
            Console.ReadLine();
        }
    }
}
