using System;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String respund = "";

            while (playAgain)
            {
                int number = random.Next(1, 101);
                int guess = 0;
                int guesses = 0;

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between 1 - 100:");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Guess: {guess}");

                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is high!");
                    } else
                    {
                        Console.WriteLine($"{guess} is low!");
                    }

                    guesses++;
                }

                Console.WriteLine($"Guess: {guess}");
                Console.WriteLine($"Number: {number}");
                Console.WriteLine("YOU WIN!");
                Console.WriteLine($"Guesses: {guesses}");
                Console.WriteLine("Would you like to play again (Y/N): ");
                respund = Console.ReadLine().ToUpper();

                if (respund == "N")
                {
                    playAgain = false;
                } 
            }

        }
    }
}
