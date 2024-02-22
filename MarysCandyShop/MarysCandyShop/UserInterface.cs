namespace MarysCandyShop
{
    internal static class UserInterface
    {
        internal const string divide = "-------------------------------";
        internal static void RunMainMenu()
        {
            ProductsController productController = new ProductsController();

            bool isMenuRunning = true;

            while (isMenuRunning)
            {
                PrintHeader();

                string usersChoice = Console.ReadLine().Trim().ToUpper();
                string menuMessage = "Press Any Key To Go Back to Menu";

                switch (usersChoice)
                {
                    case "A":
                        productController.AddProduct();
                        break;
                    case "D":
                        productController.DeleteProduct("User chose D");
                        break;
                    case "V":
                        List<Product> products = productController.GetProducts();
                        ViewProducts(products);
                        break;
                    case "U":
                        productController.UpdateProduct("User chose U");
                        break;
                    case "Q":
                        menuMessage = "Goodbye";
                        isMenuRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose one of the above.");
                        break;
                }

                Console.WriteLine(menuMessage);
                Console.ReadLine();
                Console.Clear();
            }

            
        }

        internal static void ViewProducts(List<Product> products)
        {
            Console.WriteLine(divide);

            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id}, {product.Name}, {product.Price}");
            }

            Console.WriteLine(divide);
        }
        internal static void PrintHeader()
        {
            string title = "Mary's Candy Shop";
            string divide = "---------------------------------------------";
            DateTime dateTime = DateTime.Now;
            int daysSinceOpening = Helpers.GetDaysSinceOpening();
            decimal todaysProfit = 5.5m;
            bool targetAchieved = false;
            string menu = GetMenu();

            Console.WriteLine(title);
            Console.WriteLine(divide);
            Console.WriteLine($"Today's date: {dateTime}");
            Console.WriteLine($"Days since opening: {daysSinceOpening}");
            Console.WriteLine($"Today's profit: ${todaysProfit}");
            Console.WriteLine($"Today's target achieved: {false}");
            Console.WriteLine(divide);
            Console.WriteLine(menu);
        }
        private static string GetMenu()
        {
            return @" Choose one option:
'V' to view products.
'A' to add product.
'D' to delete product.
'U' to update product.
'Q' to quit the program";
        }
    }
}
