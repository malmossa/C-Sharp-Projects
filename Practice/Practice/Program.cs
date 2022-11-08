using System;
using System.Transactions;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            while (name == "")
            {
                Console.Write("You did not enter anything!!");
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}
