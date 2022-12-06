/* Build a console application that asks a user for their name and their age.
   If their name is Bob or Sue, address them as Professor.
   If the person is 21 or older then welcome them the class.
   If the person is under 21, recommend they wait X years to start this class.*/

Console.Write("What is your name: ");
string name = Console.ReadLine();

Console.Write("What is your age: ");
string ageText = Console.ReadLine();

int age = int.Parse(ageText);

if (name.ToLower() == "bob" || name.ToLower() == "sue")
{
    Console.WriteLine("Hello Professor.");
} else if (name.ToLower() != "bob" && age < 21 || name.ToLower() != "sue" && age < 21)
{
    Console.WriteLine($"Sorry you need to wait {21 - age} more year to start this class.");
} else
{
    Console.WriteLine("Welcome to the class.");
}



Console.ReadLine();