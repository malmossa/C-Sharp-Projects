
Console.WriteLine("Please type your name");

string name = Console.ReadLine();
DateTime date = DateTime.Now;

Console.WriteLine("------------------------------");
Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game.\n");
Console.WriteLine(@$"What game would you like to play today? Choose fromthe options below:
A - Addition.
S - Subtraction.
M - Multiplication.
D - Division.
Q - Quit the game
");
Console.WriteLine("------------------------------");

string gameSelected = Console.ReadLine();

switch(gameSelected.Trim().ToLower())
{
    case "a":
        AdditionGame("Addition game is selected.");
        break;
    case "s":
        SubtractionGame("Subtraction game is selected.");
        break;
    case "m":
        MultiplicationGame("Multiplication game is selected.");
        break;
    case "d":
        DivisionGame("Division game is selected.");
        break;
    case "q":
        Console.WriteLine("GOOD BYE");
        break;
}


void AdditionGame(string message)
{
    Console.WriteLine(message);
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}






Console.ReadLine();