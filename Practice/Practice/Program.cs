using System;


namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            /* if we need to create an array of different types of objects
             * we have to fine what they have in common 
             * and then we can use that as data type
               so car and bicycle are vehicle */
            Vehicle[] vehicles = {car, bicycle};
             

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }
            
        }

    }
}

// Parent object
class Vehicle
{
    internal virtual void Go()
    {

    }
}

// these classes will inherit from the parent class
class Car : Vehicle
{
    internal override void Go()
    {
        Console.WriteLine("The car is moving.");
    }
}

class Bicycle : Vehicle
{
    internal override void Go()
    {
        Console.WriteLine("The bicycle is moving.");
    }
}
