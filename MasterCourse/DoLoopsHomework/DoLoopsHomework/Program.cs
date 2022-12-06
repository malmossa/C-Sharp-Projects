
/* Create a console application that asks the user for their name.
   Welcome me (Mansor) as professor or anytone else as student.
   Do this until the user types "exit" */

bool runAgin = true;

do
{
    Console.Write("What is you name: ");
    string name = Console.ReadLine();

    if(name.ToLower() == "mansor")
    {
        Console.WriteLine($"Welcome professor {name.ToUpper()}");
    } else
    {
        Console.WriteLine($"Welcome student {name.ToUpper()}");
    }

    Console.Write("Do you want to exit? y / n: ");
    string answer = Console.ReadLine();

    if (answer.ToLower() == "y")
    {
        runAgin = false;
        Console.WriteLine("GOODBUY!!");
    }

} while (runAgin);



Console.ReadLine();