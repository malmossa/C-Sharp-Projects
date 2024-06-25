
Console.WriteLine("Please type your name");
string name = Console.ReadLine();
DateTime date = DateTime.Now;

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. Welcome to the Math Game..\n");

Console.WriteLine(@"What game would you like to play? Choose from the option below:
A - Addition.
S - Subtraction.
M - Multiplication.
D - Division.
Q - Quit the program.");
Console.WriteLine("----------------------------------------");

string gameSelected = Console.ReadLine();

switch(gameSelected.Trim().ToUpper())
{
    case "A":
        AdditionGame("Addition game selected!");
        break;
    case "S":
        Subtraction("Subtraction game selected!");
        break;
    case "M":
        Multiplication("Multiplication game selected!");
        break;
    case "D":
        Division("Division game selected!");
        break;
    case "Q":
        Console.WriteLine("Q");
        break;
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
}

void Subtraction(string message)
{
    Console.WriteLine(message);
}

void Multiplication(string message)
{
    Console.WriteLine(message);
}

void Division(string message)
{
    Console.WriteLine(message);
}


Console.ReadLine();
        
    
