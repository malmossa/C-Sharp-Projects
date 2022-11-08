using System;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                // reset if user wants to play again
                guess = 0;
                guesses = 0;
                // get random number between 1 to 100
                number = random.Next(min, max + 1);

                response = "";

                while (guess != number)
                {
                    Console.WriteLine($"Guess a number between {min} - {max} : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Guess: {guess}");

                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is high!");
                    } else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is low!");
                    }

                    guesses++;
                }
                Console.WriteLine($"Number: {number}");
                Console.WriteLine("YOU WIN!");
                Console.WriteLine($"Guesses: {guesses}");

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine().ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                } else
                {
                    playAgain = false;
                }
                
            }

            Console.WriteLine("Thank you for playing!");
            Console.ReadKey();
        }
    }
}
