using System;
using System.Collections.Generic;


namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> food = new List<string>();

            // Add method
            food.Add("pizza");
            food.Add("Hamburger");
            food.Add("Hotdog");
            food.Add("Fries");

            // Remove method
            food.Remove("Fries");

            // Insert methos - index and item
            food.Insert(0, "Sushi");

            // Access the list
            Console.WriteLine(food[0]);
            Console.WriteLine(food[1]);
            Console.WriteLine(food[2]);

            // or with foreach loop
            foreach(String item in food)
            {
                Console.WriteLine(item);
            }

            // Getting the list size with count property
            Console.WriteLine(food.Count);

            // Finding the index of an item
            Console.WriteLine(food.IndexOf("Hotdog"));

            // Finfing to see if an item is in the list with Contains methos
            Console.WriteLine(food.Contains("Sushi"));

            //to sort the list alphabetically
            food.Sort();

            // to sort in reverse
            food.Reverse();

            // to clear the list 
            food.Clear();

            // Convert the list to an array
            String[] foodArray = food.ToArray();




            Console.ReadKey();
        }


    }
}

