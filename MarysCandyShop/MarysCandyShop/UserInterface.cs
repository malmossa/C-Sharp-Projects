namespace MarysCandyShop
{
    internal class UserInterface
    {
        internal static void RunMainMenu()
        {
            bool isMenuRunning = true;

            while (isMenuRunning)
            {
                PrintHeader();
                string usersChoice = Console.ReadLine().Trim().ToUpper();
                string menuMessage = "Press Any Key To Go Back to Menu";

                switch (usersChoice)
                {
                    case "A":
                        AddProduct();
                        break;
                    case "D":
                        DeleteProduct("User chose D");
                        break;
                    case "V":
                        ViewProducts("User chose V");
                        break;
                    case "U":
                        UpdateProduct("User chose U");
                        break;
                    case "Q":
                        menuMessage = "Goodbye";
                        SaveProducts();
                        isMenuRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, Please choose one of the above");
                        break;
                }

                Console.WriteLine(menuMessage);
                Console.ReadLine();
                Console.Clear();
            }

            void ViewProducts(string message)
            {
                Console.WriteLine(message);
            }

            void PrintHeader()
            {
                string title = "Mary's Candy Shop";
                string divide = "--------------------------------------";
                DateTime dateTime = DateTime.Now;
                int daysSinceOpening = GetDaysSinceOpening();
                decimal todaysProfit = 5.5m;
                bool targetAchieved = false;
                string menu = GetMenu();

                Console.WriteLine(title);
                Console.WriteLine(divide);
                Console.WriteLine($"Today's date: {dateTime}");
                Console.WriteLine($"Days since opening: {daysSinceOpening}");
                Console.WriteLine($"Today's profit: ${todaysProfit}");
                Console.WriteLine($"Today's target achieved: {targetAchieved}");
                Console.WriteLine(divide);
                Console.WriteLine(menu);
            }

            string GetMenu()
            {
                return @$"Choose one option:
 'V' to view products.
 'A' to add products.
 'D' to delete products.
 'U' to update products.
 'Q  to quit the program.";
            }
        }
    }
}
