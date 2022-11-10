using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;


            while (playAgain)
            {
               String computer = "";
               String player = "";

               int randomNumber = random.Next(1, 4);

               switch (randomNumber)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break ;
                }

                Console.WriteLine("Enter ROCK, PAPER, SCISSORS: ");
                player = Console.ReadLine().ToUpper();

                Console.WriteLine($"You: {player}");
                Console.WriteLine($"Computer: {computer}");


                if (player == "ROCK" && computer == "SCISSORS")
                {
                    Console.WriteLine("YOU WIN!");

                } else if (computer == "ROCK" && player == "SCISSORS")
                {
                    Console.WriteLine("YOU LOSE!");
                }


                if (player == "PAPER" && computer == "ROCK")
                {
                    Console.WriteLine("YOU WIN!");

                } else if (computer == "PAPER" && player == "ROCK")
                {
                    Console.WriteLine("YOU LOSE!");
                }


                if (player == "SCISSORS" && computer == "PAPER")
                {
                    Console.WriteLine("YOU WIN!");
                }
                else if (computer == "SCISSORS" && player == "PAPER")
                {
                    Console.WriteLine("YOU LOSE!");
                }

                if (player == computer)
                {
                    Console.WriteLine("It's a tie!");
                }

                Console.Write("Would you like to play again? (Y/N): ");
                String answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                } else
                {
                    playAgain = false;
                }

            }

            Console.WriteLine("Thanks for playing! ");
        }
    }
}
