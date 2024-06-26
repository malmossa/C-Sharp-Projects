DateTime date = DateTime.Now;

Header();

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");
    string name = Console.ReadLine();
    return name;
}
void Menu(string name)
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

    string gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToUpper())
    {
        case "A":
            AdditionGame();
            break;
        case "S":
            Subtraction();
            break;
        case "M":
            Multiplication();
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

void AdditionGame()
{
    Random random = new Random();
    int correctAnswers = 0;
    int incorrectAnswers = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        string result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your answer was correct!");
            Console.ResetColor();
            correctAnswers++;
        } else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your answer was incorrect.");
            Console.ResetColor();
            incorrectAnswers++;
        }

        if (i == 4)
        {
            Console.WriteLine("Game over.. your score is:");
            Console.Write("Correct: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(correctAnswers);
            Console.ResetColor();

            Console.Write("Incorrect: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(incorrectAnswers);
            Console.ResetColor();
        }
       

    }


}

void Subtraction()
{
    Random random = new Random();
    int correctAnswers = 0;
    int incorrectAnswers = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} - {secondNumber}");
        string result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your answer was correct!");
            Console.ResetColor();
            correctAnswers++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your answer was incorrect.");
            Console.ResetColor();
            incorrectAnswers++;
        }

        if (i == 4)
        {
            Console.WriteLine("Game over.. your score is:");
            Console.Write("Correct: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(correctAnswers);
            Console.ResetColor();

            Console.Write("Incorrect: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(incorrectAnswers);
            Console.ResetColor();
        }


    }
}

void Multiplication()
{
    Random random = new Random();
    int correctAnswers = 0;
    int incorrectAnswers = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} * {secondNumber}");
        string result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your answer was correct!");
            Console.ResetColor();
            correctAnswers++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your answer was incorrect.");
            Console.ResetColor();
            incorrectAnswers++;
        }

        if (i == 4)
        {
            Console.WriteLine("Game over.. your score is:");
            Console.Write("Correct: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(correctAnswers);
            Console.ResetColor();

            Console.Write("Incorrect: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(incorrectAnswers);
            Console.ResetColor();
        }


    }
}

void Division(string message)
{
    Console.WriteLine(message);
}



Console.ReadLine();
        
    
