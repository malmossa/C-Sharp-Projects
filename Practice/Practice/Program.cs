using System;
using System.Collections.Generic;


namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(200);

            car.Speed = 300;

            Console.ReadKey();
        }

        class Car
        {
            private int speed;

            public Car(int speed)
            {
                Speed = speed;
            }

            public int Speed
            {
                get { return speed; } 
                set { speed = value; }
            }
        }
    }
}

