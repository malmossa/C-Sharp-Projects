Header();

Console.WriteLine("Please type your name");
string name = Console.ReadLine();
DateTime date = DateTime.Now;

Menu(name, date);

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
        Console.WriteLine("Goodbye");
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}

void Menu(string name, DateTime date)
{
    int militaryTime = Convert.ToInt32(date.Hour.ToString());

    string userGreeting = Greeting(militaryTime);
    Console.WriteLine($"{userGreeting} {name.ToUpper()}.\n");

    Console.WriteLine(@"What game would you like to play? Choose from the option below:
A - Addition.
S - Subtraction.
M - Multiplication.
D - Division.
Q - Quit the program.");
    Console.WriteLine("------------------------------------------------------");

}

string Greeting(int hour)
{
    string message = "";
    if (hour > 0 && hour <= 12)
    {
        message = "Good morning";
    }
    else if (hour >= 12 && hour <= 5)
    {
        message = "Good afternoon";
    }
    else
    {
        message = "Good eveing";
    }

    return message; 
}

void Header()
{
    Console.WriteLine(@"   
                                 _   _ 
                                | | | |    
                 _ __ ___   __ _| |_| |__ 
                | '_ ` _ \ / _` | __| '_ \
                | | | | | | (_| | |_| | | |
 WELCOME TO THE |_| |_| |_|\__,_|\__|_| |_| GAME ");

 Console.WriteLine("------------------------------------------------------");
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
        
    
