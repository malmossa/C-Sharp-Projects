using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defence of Consola";
            Console.WriteLine("What is the target row? ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the target column? ");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Target row: " + row);
            Console.WriteLine("Target column: " + column);
            Console.WriteLine("Deploy to:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"({row}, {column - 1})");
            Console.WriteLine($"({row - 1}, {column})");
            Console.WriteLine($"({row}, {column + 1})");
            Console.WriteLine($"({row + 1}, {column})");

            Console.Beep();

            Console.ReadKey();
        }
    }
}
