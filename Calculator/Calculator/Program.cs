

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("******************************");
            Console.WriteLine("***** CONSOLE CALCULATOR *****");
            Console.WriteLine("******************************");

            while (!endApp)
            {
                string numberInput1 = "";
                string numberInput2 = "";

                double result = 0;

                Console.Write("Type a number, thenpress Enter: ");
                numberInput1 = Console.ReadLine();

                double cleanNumber1 = 0;

                while (!double.TryParse(numberInput1, out cleanNumber1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numberInput1 = Console.ReadLine();
                }

                Console.Write("Type another number, thenpress Enter: ");
                numberInput2 = Console.ReadLine();

                double cleanNumber2 = 0;

                while (!double.TryParse(numberInput2, out cleanNumber2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numberInput2 = Console.ReadLine();
                }

                Console.WriteLine("Choose an operator from the following list: ");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string operation = Console.ReadLine();

                try
                {
                    result = CalculatorLibrary.Calculator.DoOperation(cleanNumber1, cleanNumber2, operation);

                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error. \n ");
                    }
                    else
                    {
                        Console.WriteLine("Your result: {0:0.#}\n", result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math. \n - Details: " + e.Message);
                }

                Console.WriteLine("---------------------------------\n");

                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");

                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");


            }

            return;



            Console.ReadLine();

        }
    }
}
    











