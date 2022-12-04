using System;

namespace temp
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Add("total is ", 2, 2.00);
        }

        
        
        
        static void Add(string message, int num1, double num2)
        {
            Console.WriteLine(message + (num1 + num2));
        }

        
    }
}
