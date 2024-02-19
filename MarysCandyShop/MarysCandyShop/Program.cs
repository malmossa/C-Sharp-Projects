string docPath = @"C:\Users\malmo\C-Sharp-Projects\MarysCandyShop\MarysCandyShop\history.txt";

string[] candyNames = { "Rainbow Lollipops", "Cotton Candy Clouds", "Choco-Caramel Delights", "Gummy Bear Bonanza",
    "Minty Chocolate Truffles", "Jellybean Jamboree", "Fruity Taffy Twists", "Sour Patch Surprise",
    "Crispy Peanut Butter Cups", "Rock Candy Crystals"};

bool isMenuRunning = true;
List<string> products = new List<string>();
SeedData();

while(isMenuRunning)
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
            Console.WriteLine("Invalid choice. Please choose one of the above.");
            break;
    }

    Console.WriteLine(menuMessage);
    Console.ReadLine();
    Console.Clear();
}

void SeedData()
{
    for (int i = 0; i < candyNames.Length; i++)
    {
        products.Add(candyNames[i]);
    }
}



void AddProduct()
{
    Console.WriteLine("Product name:");
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
void PrintHeader()
{
    string title = "Mary's Candy Shop";
    string divide = "---------------------------------------------";
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
    Console.WriteLine($"Today's target achieved: {false}");
    Console.WriteLine(divide);
    Console.WriteLine(menu);
}

string GetMenu()
{
    return @" Choose one option:
'V' to view products.
'A' to add product.
'D' to delete product.
'U' to update product.
'Q' to quit the program" ;
}

int GetDaysSinceOpening()
{
    DateTime openingDate = new DateTime(2023, 1, 1);
    TimeSpan timeDifference = DateTime.Now - openingDate;

    return timeDifference.Days;
}


void SaveProducts()
{
    using(StreamWriter outputFile = new StreamWriter(docPath))
    {
        foreach (var product in products)
        {
            outputFile.WriteLine(product);
        }
    }
    Console.WriteLine("Products saved");
}


Console.ReadLine();