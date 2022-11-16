using System;


namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        }

        interface IPrey
        {
            void Flee();
        }

        interface IPredator
        {
            void Hunt();
        }

        class Rabbit : IPrey 
        {
            public void Flee()
            {
                Console.WriteLine("The rabbit runs a way!");
            }
        }

        class Hawk : IPredator
        {
            public void Hunt()
            {
                Console.WriteLine("The hawk is searching for food!");
            }
        }

        class Fish : IPrey, IPredator
        {
            public void Flee()
            {
                Console.WriteLine("The fish swims away!");
            }

            public void Hunt()
            {
                Console.WriteLine("The fish is searching for smaller fish!");
            }
        }

    }
}

