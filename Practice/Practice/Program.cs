using System;
using System.Collections.Generic;


namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Porsch");

            Console.WriteLine(car.Model);

            Console.ReadKey();
        }

        class Car
        {
           public String Model { get; set; }

           public Car(String model)
            {
                this.Model = model;
            }

           
        }
    }
}

