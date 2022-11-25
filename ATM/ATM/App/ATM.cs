using System;

namespace ATM.App
{
    public class ATM
    {
        static void Main(string[] args)
        {
            Console.Title = "ATM APP";
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n---------- Welcome to The ATM Program ----------\n\n");

            // prompt the user to insert ATM card
            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("NOTE: This is a virtual ATM");

            Console.ReadLine();
        }
    }
}
