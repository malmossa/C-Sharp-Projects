string docPath = @"C:\\Users\\malmo\\C-Sharp-Projects\\MarysCandyShop\\MarysCandyShop\\history.txt";

string[] candyNames = { "Rainbow Lollipops", "Cotten Candy Clouds", "Choco-Caramel Delights", "Gummy Bear", "Bonanza",
                        "Minty Chocolate Truffles", "Jellybean Jamboree", "Fruity Taffy Twists", "Sour Patch Surprise", 
                        "Crispy Peanut Butter Cups", "Rock Candy Crystals"};

List<string> products = new List<string>();
SeedData();

string divide = "--------------------------------------";

bool isMenuRunning = true;

while (isMenuRunning)
{
    PrintHeader();
    string usersChoice = Console.ReadLine().Trim().ToUpper();
    string menuMessage = "Press Any Key To Go Back to Menu";

    switch(usersChoice)
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



void SeedData()
{
    for(int i = 0; i < candyNames.Length; i++)
    {
        products.Add(candyNames[i]);
    }
}
void AddProduct()
{
    Console.WriteLine("Product name: ");
    string product = Console.ReadLine();
    products.Add(product);
}

void DeleteProduct(string message)
{
    Console.WriteLine(message);
}

void UpdateProduct(string message)
{
    Console.WriteLine(message);
}

void ViewProducts(string message)
{
    Console.WriteLine(message);
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

int GetDaysSinceOpening ()
{
    DateTime openingDate = new DateTime(2024, 1, 1);
    TimeSpan timeDifference = DateTime.Now - openingDate;

    return timeDifference.Days;
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



void SaveProducts()
{
    using(StreamWriter outputFile = new StreamWriter(docPath))
    {
        foreach(string product in products)
        {
            outputFile.WriteLine(product);
        }
    }
    Console.WriteLine("Products saved");
}

Console.ReadLine();

