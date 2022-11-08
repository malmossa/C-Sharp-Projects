using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You are now signed up!");
            } else if (age <= 0)
            {
                Console.WriteLine("You have not been born yet!!");
            } 
            else
            {
                Console.WriteLine("You must be 18+ to sign up!");
            }

            Console.ReadKey();
        }
    }
}
