DateTime date = DateTime.Now;

List<string> games = new List<string>();

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
    bool isGameOn = true;

    // Show the greeting only once
    Greeting(name);


    while (isGameOn)
    {
        Console.WriteLine(@"What game would you like to play? Choose from the option below:
     V - View Previous Games.
     A - Addition.
     S - Subtraction.
     M - Multiplication.
     D - Division.
     Q - Quit the program.");
        Console.WriteLine("------------------------------------------------------");

        string gameSelected = Console.ReadLine();

        switch (gameSelected.Trim().ToUpper())
        {
            case "V":
                GetGames();
                break;
            case "A":
                AdditionGame("Addition Game");
                break;
            case "S":
                SubtractionGame("Subtraction Game");
                break;
            case "M":
                MultiplicationGame("Multiplication Game");
                break;
            case "D":
                DivisionGame("Division Game");
                break;
            case "Q":
                Console.WriteLine($"Goodbye.. {name}");
                Environment.Exit(0);
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
        Console.Clear();
    } 

}

void Greeting(string name)
{
    int hour = Convert.ToInt32(date.Hour.ToString());

    
    if (hour > 0 && hour <= 12)
    {
        Console.WriteLine($"Good morning.. {name}");
    }
    else if (hour >= 12 && hour <= 5)
    {
        Console.WriteLine($"Good afternoon.. {name}");
    }
    else
    {
        Console.WriteLine($"Good eveing.. {name}");
    }

}

void Header()
{
  Console.WriteLine("******************************************************");
  Console.WriteLine("*************  WELCOM TO THE MATH GAME  **************");
  Console.WriteLine("******************************************************");
}

void AdditionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    Random random = new Random();
    int correctAnswers = 0;
    int wrongAnswers = 0;

    int firstNumber = 0;
    int secondNumber = 0;

    string gameLevel = Difficulty();

    for (int i = 0; i < 5; i++)
    {

        if (gameLevel == "Easy")
        {
            firstNumber = random.Next(1, 26);
            secondNumber = random.Next(1, 26);
        }

        if (gameLevel == "Medium")
        {
            firstNumber = random.Next(1, 51);
            secondNumber = random.Next(1, 51);
        }

        if (gameLevel == "Difficult")
        {
            firstNumber = random.Next(1, 101);
            secondNumber = random.Next(1, 101);
        }

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        string result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!\n");
            Console.ResetColor();
            correctAnswers++;
        } else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong!\n");
            Console.ResetColor();
            wrongAnswers++;
        }

        if (i == 4)
        {
            Console.WriteLine("Game over.. your score is:");
            Console.Write("Correct: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(correctAnswers);
            Console.ResetColor();

            Console.Write("Wrong: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(wrongAnswers);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadLine();
        }
       

    }

    AddToHistory(correctAnswers, wrongAnswers, "Addition", gameLevel);

}

void SubtractionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    Random random = new Random();
    int correctAnswers = 0;
    int wrongAnswers = 0;

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
            Console.WriteLine("Your answer was correct!\n");
            Console.ResetColor();
            correctAnswers++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your answer was incorrect.\n");
            Console.ResetColor();
            wrongAnswers++;
        }

        if (i == 4)
        {
            Console.WriteLine("Game over.. your score is:");
            Console.Write("Correct: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(correctAnswers);
            Console.ResetColor();

            Console.Write("Wrong: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(wrongAnswers);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadLine();
        }


    }

    AddToHistory(correctAnswers, wrongAnswers, "Subtraction");
}

void MultiplicationGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    Random random = new Random();
    int correctAnswers = 0;
    int wrongAnswers = 0;

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
            Console.WriteLine("Your answer was correct!\n");
            Console.ResetColor();
            correctAnswers++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your answer was incorrect.\n");
            Console.ResetColor();
            wrongAnswers++;
        }

        if (i == 4)
        {
            Console.WriteLine("Game over.. your score is:");
            Console.Write("Correct: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(correctAnswers);
            Console.ResetColor();

            Console.Write("Wrong: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(wrongAnswers);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }
    
    AddToHistory(correctAnswers, wrongAnswers, "Multiplication");
}

void DivisionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    int correctAnswers = 0;
    int wrongAnswers = 0;

    for (int i = 0; i < 5; i++)
    {
        int[] divisionNumbers = GetDivisionNumbers();
        int firstNumber = divisionNumbers[0];
        int secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        string result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your answer was correct!\n");
            Console.ResetColor();
            correctAnswers++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your answer was incorrect.\n");
            Console.ResetColor();
            wrongAnswers++;
        }

        if (i == 4)
        {
            Console.WriteLine("Game over.. your score is:");
            Console.Write("Correct: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(correctAnswers);
            Console.ResetColor();

            Console.Write("Wrong: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(wrongAnswers);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadLine() ;
        }
    }

    AddToHistory(correctAnswers, wrongAnswers, "Division");
}

int[] GetDivisionNumbers()
{
    Random random = new Random();
    int firstNumber = random.Next(0, 99);
    int secondNumber = random.Next(0, 99);

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

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games Hestory");
    Console.WriteLine("-------------------");

    foreach (string game in games)
    {
        Console.WriteLine(game);
    }

    Console.WriteLine("-------------------\n");
    Console.WriteLine("Press any key to go back to the main menu.");
    Console.ReadLine();
}

void AddToHistory(int correct, int wrong, string gameType, string difficulty)
{
    games.Add($"{DateTime.Now} - {gameType} - {difficulty} - Correct: {correct} Wrong: {wrong}");
}

string Difficulty()
{
    string difficulty = "";

    Console.WriteLine(@"How difficult you want the game to be? 
    E - Easy, numbers 1 to 25.
    M - Medium, numbers 1 to 50.
    D - Difficult, numbers 1 to 100.");

    string userChoice = Console.ReadLine();

    switch (userChoice.Trim().ToUpper())
    {
        case "E":
            difficulty = "Easy";
            break;
        case "M":
            difficulty = "Medium";
            break;
        case "D":
            difficulty = "Difficult";
            break;
    }
    return difficulty;
}



Console.ReadLine();
        
    
