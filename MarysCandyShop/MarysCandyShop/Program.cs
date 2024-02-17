
string title = "Mary's Candy Shop";
string divide = "---------------------------------------------";
DateTime dateTime = DateTime.Now;
int daysSinceOpening = 1;
decimal todaysProfit = 5.5m;
bool targetAchieved = false;
string menu = @" Choose one option:
'V' to view products.
'A' to add product.
'D' to delete product.
'U' to update product.";


Console.WriteLine(title);
Console.WriteLine(divide);
Console.WriteLine($"Today's date: {dateTime}");
Console.WriteLine($"Days since opening: {daysSinceOpening}");
Console.WriteLine($"Today's profit: ${todaysProfit}");
Console.WriteLine($"Today's target achieved: {false}");
Console.WriteLine(divide);
Console.WriteLine(menu);

Console.WriteLine(divide);
Console.WriteLine(divide);

title = title.ToUpper();
divide = divide.Insert(0, "#########");
dateTime = dateTime.Date;
daysSinceOpening = 2;
todaysProfit = 10.9m;
targetAchieved = true;

Console.ReadLine();