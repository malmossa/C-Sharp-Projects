/* Create an array of 3 names. Ask the user which number to select.
   When the user gives you a number, return that name.
   Make sure to check for invalid number.*/

string[] names = { "Tim", "Bob", "Suue"};

bool isValid;

do
{
    Console.Write("Choos a number between 0 to 2: ");
    string numberText = Console.ReadLine();

    isValid = int.TryParse(numberText, out int number);

    if (isValid)
    {
        Console.WriteLine($"The name is: {names[number]}");
    } else
    {
        Console.WriteLine("Please enter a valid number!");
    }

} while (!isValid);












Console.ReadLine();
