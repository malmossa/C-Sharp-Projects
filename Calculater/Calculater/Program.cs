using System;

namespace Calculater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");

            do
            {

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($@"Choose an option from the list below: 
                A - Add.
                S - Subtract.
                M - Multiplay.
                D - Divide. 
                ");
                Console.Write("Enter an option: ");

                switch (Console.ReadLine().ToUpper())
                {
                    case "A":
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2} \a");
                        break;
                    case "S":
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2} ");
                        break;
                    case "M":
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2} ");
                        break;
                    case "D":
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2} ");
                        break;
                }

                Console.Write("Would you like to continue? (Y/N): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Thanks for using the calculator program.");
        }
    }
}
