using System;

namespace ATMApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            void printOptions()
            {
                Console.WriteLine("Please choose from one of the following options...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("1. Withdr");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("1. Deposit");
            }

            void deposit(CardHolder currentUser)
            {
                Console.WriteLine("How much $$ would you like to deposite? ");
                double deposit = Double.Parse(Console.ReadLine());
                currentUser.setBalance(deposit);
                Console.WriteLine("Thank you for your $$. Your new balance is: " + currentUser.getBalance());
            }
            
            
            
            Console.ReadLine();
        }
    }
}

