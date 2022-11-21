
namespace MathGame
{
    public class Menu
    {
        GameEngine engine = new GameEngine();
        Helpers helpers = new Helpers();
        public void ShowMenu(string name, DateTime date)
        {

            bool isGameOn = true;

            do
            {
                Console.Clear();

                Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game.\n");
                Console.WriteLine(@$"What game would you like to play today? Choose fromthe options below:
                V - View Previous Games.
                A - Addition.
                S - Subtraction.
                M - Multiplication.
                D - Division.
                Q - Quit the game
                ");
                Console.WriteLine("------------------------------");

                string gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        helpers.GetGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition game.");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction game.");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication game.");
                        break;
                    case "d":
                        engine.DivisionGame("Division game.");
                        break;
                    case "q":
                        Console.WriteLine("GOODBYE");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input.");
                        break;
                }
            } while (isGameOn);

        }
    }
}
