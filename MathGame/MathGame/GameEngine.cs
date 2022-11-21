using MathGame;

namespace MathGame
{
    public class GameEngine
    {
        Helpers helpers = new Helpers();
        public void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Random random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                string result = Console.ReadLine();
                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect!");
                }
            }

            helpers.AddToHistory("Addition", score);

            Console.WriteLine();
            Console.WriteLine($"GAME OVER, your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }

        public void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Random random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                string result = Console.ReadLine();
                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect!");
                }
            }
            helpers.AddToHistory("Subtraction", score);

            Console.WriteLine();
            Console.WriteLine($"GAME OVER, your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }


        public void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Random random = new Random();
            int score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                string result = Console.ReadLine();
                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect!");
                }
            }
            helpers.AddToHistory("Multiplication", score);

            Console.WriteLine();
            Console.WriteLine($"GAME OVER, your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }


        public void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                int[] divisionNumbers = helpers.GetDivisionNumbers();
                int firstNumber = divisionNumbers[0];
                int secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                string result = Console.ReadLine();
                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect!");
                }
            }
            helpers.AddToHistory("Division", score);

            Console.WriteLine();
            Console.WriteLine($"GAME OVER, your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
        }
    }
}
