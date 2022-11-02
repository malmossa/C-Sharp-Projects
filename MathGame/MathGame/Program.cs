
using static System.Formats.Asn1.AsnWriter;

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

    bool isGameOn = true;

    do
    {
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
                AdditionGame("Addition game");
                break;
            case "s":
                SubtractionGame("Subtraction game");
                break;
            case "m":
                MultiplicationGame("Multiplication game");
                break;
            case "d":
                DivisionGame("Division game");
                break;
            case "q":
                Console.WriteLine("Goodbye");
                isGameOn = false;
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }

     } while (isGameOn) ;

 }

void AdditionGame( string message)
{
    Console.Clear();
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
            Console.WriteLine("Your answer is correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        } else
        {
            Console.WriteLine("Your answer is incorrect. Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) { Console.WriteLine($"GAME OVER !! Your final score: {score}"); }
    }

    
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
            Console.WriteLine("Your answer is correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer is incorrect. Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) { Console.WriteLine($"GAME OVER !! Your final score: {score}"); }
    }

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
            Console.WriteLine("Your answer is correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer is incorrect. Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) { Console.WriteLine($"GAME OVER !! Your final score: {score}"); }
    }
}

void DivisionGame(string message)
{
   int score = 0;

   for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        int[] divisionNumbers = GetDivisionNumber();
        int firstNumber = divisionNumbers[0];
        int secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        string result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer is correct! Type any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer is incorrect. Type any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) { Console.WriteLine($"GAME OVER !! Your final score: {score}"); }
    }
}

int[] GetDivisionNumber()
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




