
namespace MathGame
{
    public class Helpers
    {
        static List<string> games = new List<string>();
        public void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------");

            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Press any key to retirm to main Menu");
            Console.ReadLine();
        }
        public int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int firstNumber = random.Next(1, 99);
            int secondNumber = random.Next(1, 99);

            int[] result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            }
            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        public void AddToHistory(string gameType, int gameScore)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score = {gameScore}");
        }
    }
}
