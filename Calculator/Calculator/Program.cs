// Declare variables and then initialize to zero.
int num1 = 0;
int num2 = 0;

// Display title as the C# console calculator app.
Console.WriteLine("Console Calculator in C#");
Console.WriteLine("-------------------------");

// Ask the user to type the first number.
Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number
Console.WriteLine("Type another number, and then press Enter");
num2 = Convert.ToInt32(Console.ReadLine());

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("a - Add");
Console.WriteLine("s - Subtract");
Console.WriteLine("m - Multiplay");
Console.WriteLine("d - Divide");
Console.WriteLine("Your option?");

// use a switch statment to do the math.
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} x {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}

// Wait for the user to respod before closing.
Console.WriteLine("Press any key to close the Calculator console app...");
Console.ReadKey();



