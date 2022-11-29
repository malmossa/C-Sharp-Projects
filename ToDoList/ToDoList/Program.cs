using System;
using System.Collections.Generic;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TO DO LIST";
            Console.ForegroundColor= ConsoleColor.White;

            DateTime date= DateTime.Now;

            List<string> todos = new List<string>();

            bool addOrRemove = true;

            Console.WriteLine("What is you name? ");
            string name = Console.ReadLine();

            Console.WriteLine($"\nHello {name}. today is {date.DayOfWeek} and the time is {date.Hour}:{date.Minute}\n");
            Console.WriteLine($@"Please choose from the options below: 
     V - View todo items.
     A - Add new todo item.
     R - Remove a todo item.
     ");
            string userChoice = Console.ReadLine();

            switch (userChoice.ToUpper().Trim())
            {
                case "V":
                    Console.WriteLine("V is selected");
                    break;
                case "A":
                    while (addOrRemove)
                    {
                        Console.Write("Add new to do item: ");
                        todos.Add(Console.ReadLine());
                        Console.WriteLine("your todo item was added..");
                        Console.WriteLine("Do you want to add more items? y/n");
                        string answer = Console.ReadLine();

                        if (answer.ToLower().Trim() == "n")
                        {
                            addOrRemove = false;
                        }
                    }
                    break;
                case "R":
                    Console.WriteLine("R is selected");
                    break;
            }




            Console.ReadLine();
        }
    }
}
