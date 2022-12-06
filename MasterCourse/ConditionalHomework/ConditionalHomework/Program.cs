
/* Create a console application that asks the user for their name.
   Welcome me (Mansor) as professor or anyone else as student.
   Make sure that "Mansor" also gets called professor. */

Console.WriteLine("What is your name? ");

string name = Console.ReadLine();

if (name.ToLower() == "mansor")
{
    Console.WriteLine($"Welcome professor {name}.");
} else
{
    Console.WriteLine($"Welcome student {name}.");
}


Console.ReadLine();


