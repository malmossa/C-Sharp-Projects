using System;

namespace ToDoList 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;

            Console.Title = "To Do List";
            Console.ForegroundColor= ConsoleColor.White;

            Console.WriteLine("------------------------------");
            Console.WriteLine("         TO DO LIST           ");
            Console.WriteLine("------------------------------");

            Console.WriteLine("\nWhat is you name? ");
            string name = Console.ReadLine();

            Console.WriteLine($"\nHello {name}, today is {date.DayOfWeek} at {date.ToShortTimeString()}. Please choose one of the options below: ");
            Console.WriteLine($@"
         V - View to do items.   
         A - Add to do item.
         R - Remove to do item.   
            ");




            Console.ReadLine();
        }
    }
}
