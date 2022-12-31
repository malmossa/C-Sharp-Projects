using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            displayItems(10);

            Console.ReadLine();
        }
        public static void displayItems(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine($"{i}, {j}, {k}");
                    }
                }
            }
        }
    }
}











