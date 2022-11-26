
namespace ATM.UI
{
    public class AppScreen
    {
        public static void Welcome()
        {
            Console.Title = "ATM APP";
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n---------- Welcome to The ATM Program ----------\n\n");

            // prompt the user to insert ATM card
            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("NOTE: This is a virtual ATM");

            Utility.PressEnterToContinue();

        }

    }
}
