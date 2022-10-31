
DateTime date = DateTime.Now;
string name = GetName();



Menu(name);


// Methods

string GetName()
{
    Console.WriteLine("Please type your name");
    string name = Console.ReadLine();
    return name; 
}

void Menu(string name) {
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

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid input!");
            Environment.Exit(0);
            break;
    }
}

void AdditionGame( string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i ++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        string result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer is correct!");
            score++;
        } else
        {
            Console.WriteLine("Your answer is incorrect.");
        }

        if (i == 4) { Console.WriteLine($"GAME OVER !! Your final score: {score}"); }
    }

    
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int score = 0;

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
            Console.WriteLine("Your answer is correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer is incorrect.");
        }

        if (i == 4) { Console.WriteLine($"GAME OVER !! Your final score: {score}"); }
    }

}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int score = 0;

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
            Console.WriteLine("Your answer is correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer is incorrect.");
        }

        if (i == 4) { Console.WriteLine($"GAME OVER !! Your final score: {score}"); }
    }
}

void DivisionGame(string message)
{
    GetDivisionNumber();
}

int[] GetDivisionNumber()
{
    Random random = new Random();
    int firstNumber = random.Next(0, 99);
    int seconNumber = random.Next(0, 99);

    int[] result = new int[2];

    result[0] = firstNumber;
    result[1] = seconNumber;

    Console.WriteLine(result);

    return result;
}

Console.ReadLine(); 




