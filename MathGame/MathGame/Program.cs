﻿DateTime date = DateTime.Now;

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

    bool isGameOn = true;

    while (isGameOn)
    {
        Console.Clear();
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
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
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
            Console.WriteLine("Your answer was correct!\n");
            Console.ResetColor();
            correctAnswers++;
        } else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your answer was incorrect.\n");
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
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadLine();
        }
       

    }


}

void SubtractionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

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
            Console.WriteLine("Your answer was correct!\n");
            Console.ResetColor();
            correctAnswers++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your answer was incorrect.\n");
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
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadLine();
        }


    }
}

void MultiplicationGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

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
            Console.WriteLine("Your answer was correct!\n");
            Console.ResetColor();
            correctAnswers++;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your answer was incorrect.\n");
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
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadLine();
        }


    }
}

void DivisionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    int correctAnswers = 0;
    int incorrectAnswers = 0;

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
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadLine() ;
        }
    }
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



Console.ReadLine();
        
    
