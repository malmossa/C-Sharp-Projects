using ATM.UI;
using System;

namespace ATM.App
{
    public class ATM
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            string cardNumber = Utility.GetUserInput("your card number");

            Console.WriteLine($"Your card number is {cardNumber}");
            Utility.PressEnterToContinue();
        }
    }
}
