using System;
using System.Collections.Generic;


namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine((int)StudentID.Mansor);
            
            Console.ReadLine();
        }

        enum StudentID
        {
           Mansor = 100,
           Mohammed = 101,
           Nujood = 102
        }

        
    }
}

