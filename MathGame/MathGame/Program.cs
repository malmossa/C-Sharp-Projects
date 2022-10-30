
Console.WriteLine("Please type your name");

string name = Console.ReadLine();
DateTime date = DateTime.Now;



Menu(name, date);


// Methods

void Menu(string name, DateTime date) {
    Console.WriteLine("-------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game.\n");
    Console.WriteLine($@"What game would you like to play today? Choose from the option below:
    A - Addition
    S - Subtraction
    M - Multiplication
    D - Division
    Q - Quit the program");
    Console.WriteLine("--------------------------------------");

    string gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid input!");
            Environment.Exit(0);
            break;
    }
}

void AdditionGame( string message)
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



