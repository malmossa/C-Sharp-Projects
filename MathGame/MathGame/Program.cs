using System;

Console.WriteLine("Please type your name");

string name = Console.ReadLine();
DateTime date = DateTime.Now;


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

if (gameSelected.Trim().ToLower() == "a")
{
    AdditionGame("Addition game selected");
} else if (gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame("Subtraction game selected");
} else if (gameSelected.Trim().ToLower() == "m")
{
    MultiplicationGame("Multiplication game selected");
} else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame("Division game selected");
} else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye");

    Environment.Exit(1);
} else
{
    Console.WriteLine("Invalid input!");

}


// Methods

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



