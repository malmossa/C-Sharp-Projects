using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.99;
            double y = 5;

            double z = Math.Max(x, y);
            double g = Math.Min(x, y);

            Console.WriteLine(z);
            Console.WriteLine(g);

            Console.ReadKey();
        }
    }
}
