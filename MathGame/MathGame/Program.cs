
DateTime date = DateTime.Now;

string name = GetName();
Menu(name);

void Menu(string name)
{

    bool isGameOn = true;

    do
    {
        Console.Clear();
        
        Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game.\n");
        Console.WriteLine(@$"What game would you like to play today? Choose fromthe options below:
        A - Addition.
        S - Subtraction.
        M - Multiplication.
        D - Division.
        Q - Quit the game
        ");
        Console.WriteLine("------------------------------");

        string gameSelected = Console.ReadLine();

        switch(gameSelected.Trim().ToLower())
        {
            case "a":
                AdditionGame("Addition game.");
                break;
            case "s":
                SubtractionGame("Subtraction game.");
                break;
            case "m":
                MultiplicationGame("Multiplication game.");
                break;
            case "d":
                DivisionGame("Division game.");
                break;
            case "q":
                Console.WriteLine("GOODBYE");
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid Input.");
                break;
        }
    } while (isGameOn);

}

void AdditionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    Random random = new Random();
    int score = 0;

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
            Console.WriteLine("Your answer was correct!");
            score++;
        } else
        {
            Console.WriteLine("Your answer was incorrect!");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"GAME OVER, your final score is {score}. Press any key to go back to the main menu");
    Console.ReadLine();
}

void SubtractionGame(string message)
{
    Console.Clear();
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
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect!");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"GAME OVER, you got {score} correct");
}

void MultiplicationGame(string message)
{
    Console.Clear();
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
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect!");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"GAME OVER, you got {score} correct");
}

void DivisionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        int[] divisionNumbers = GetDivisionNumbers();
        int firstNumber = divisionNumbers[0];
        int secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        string result = Console.ReadLine();
        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect!");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"GAME OVER, you got {score} correct");
}


string GetName()
{
    Console.WriteLine("Please type your name");
    string name = Console.ReadLine();
    return name;
}


int[] GetDivisionNumbers()
{
    Random random = new Random();
    int firstNumber = random.Next(1, 99);
    int secondNumber = random.Next(1, 99);

    int[] result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }
    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}






Console.ReadLine();