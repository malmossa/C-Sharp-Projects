
Console.WriteLine("******************************");
Console.WriteLine("***** CONSOLE CALCULATOR *****");
Console.WriteLine("******************************");

double number1 = 0;
double number2 = 0;

Console.WriteLine("Type a number, and then press enter");
number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Type another number, and then press enter");
number2 = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine();

Console.WriteLine("Choose an option from the folloing list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");

Console.WriteLine();

Console.Write("Your option? ");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {number1} + {number2} = {number1 + number2} ");
        break;

    case "s":
        Console.WriteLine($"Your result: {number1} - {number2} =  {number1 - number2} ");
        break;
    case "m":
        Console.WriteLine($"Your result: {number1} * {number2} = {number1 * number2} ");
        break;
    case "d":
        while (number2 == 0)
        {
            Console.WriteLine("Enter a non-zero divisor: ");
            number2 = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"Your result: {number1} / {number2} = {number1 / number2} ");
        break;
}

Console.WriteLine();

Console.WriteLine("Press any key to close the Calculator console app ...");


Console.ReadKey();
