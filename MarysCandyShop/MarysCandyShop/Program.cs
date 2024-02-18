
PrintHeader();

string usersChoice = Console.ReadLine().Trim().ToUpper();

switch(usersChoice)
{
    case "A":
        AddProduct("User chose A");
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
    default:
        Console.WriteLine("Invalid choice. Please choose one of the above.");
        break;
}


void AddProduct(string message)
{
    Console.WriteLine(message);
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
'U' to update product.";
}

int GetDaysSinceOpening()
{
    DateTime openingDate = new DateTime(2023, 1, 1);
    TimeSpan timeDifference = DateTime.Now - openingDate;

    return timeDifference.Days;
}



Console.ReadLine();