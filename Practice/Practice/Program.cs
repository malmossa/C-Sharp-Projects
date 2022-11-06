using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x; // declaration
            x = 123; // initialization

            int y = 321; // declaration + initialization

            int age = 21; // whole integer
            double height = 5.3; // decimal number
            bool alive = true; // true or false
            char symbol = '@'; // single quotes
            String name = "Mansor";
            
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + " foot");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            Console.ReadKey();
        }
    }
}
