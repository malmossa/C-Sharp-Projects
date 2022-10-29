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


Console.ReadLine();



