using MarysCandyShop;


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



Console.ReadLine();

