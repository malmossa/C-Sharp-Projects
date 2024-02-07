
string title = "Mary's Candy Shop";
string divide = "--------------------------------------";
DateTime dateTime = DateTime.Now;
int daysSinceOpening = 1;
decimal todaysProfit = 5.5m;
bool targetAchieved = false;
string menu = @$"Choose one option:
 'V' to view products.
 'A' to add products.
 'D' to delete products.
 'U' to update products.";

Console.WriteLine(title);
Console.WriteLine(divide);
Console.WriteLine($"Today's date: {dateTime}");
Console.WriteLine($"Days since opening: {daysSinceOpening}");
Console.WriteLine($"Today's profit: {todaysProfit} $");
Console.WriteLine($"Today's target achieved: {targetAchieved}");
Console.WriteLine(divide);
Console.WriteLine(menu);

string usersChoice = Console.ReadLine().Trim().ToUpper();

switch(usersChoice)
{
    case "A":
        Console.WriteLine("User chose A");
        break;
    case "D":
        Console.WriteLine("User chose D");
        break;
    case "V":
        Console.WriteLine("User chose V");
        break;
    case "U":
        Console.WriteLine("User chose U");
        break;
}


Console.ReadLine();

