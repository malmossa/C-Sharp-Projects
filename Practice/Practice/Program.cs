using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;

            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "rock" && player != "paper" && player != "scissors")
                {
                    Console.WriteLine("Enter ROCK, PAPER, SCISSORS: ");
                    player = Console.ReadLine().ToLower();
                }

                int randomNumber = random.Next(1, 4);
                switch (randomNumber)
                {
                    case 1:
                        computer = "rock";
                        break;
                    case 2:
                        computer = "paper";
                        break ;
                    case 3:
                        computer = "scissors";
                        break;
                }

                Console.WriteLine($"Player: {player}");
                Console.WriteLine($"Computer: {computer}");

                switch (player)
                {
                    case "rock":
                        if (computer == "rock")
                        {
                            Console.WriteLine("It's a draw!");
                        } else if (computer == "paper")
                        {
                            Console.WriteLine("You lose!");
                        } else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "paper":
                        if (computer == "rock")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "scissors":
                        if (computer == "rock")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                Console.Write("Would you like to play again (Y/N): ");
                String respond = Console.ReadLine().ToUpper();
                if (respond == "Y")
                {
                    playAgain = true;
                } else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}
