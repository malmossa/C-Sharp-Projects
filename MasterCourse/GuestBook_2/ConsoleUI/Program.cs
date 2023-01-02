using System;
using System.Collections.Generic;
using GuestBookLibrary.Models;

namespace ConsoleUI
{
    class Program
    {
        private static List<GuestBookModel> guests = new List<GuestBookModel>();

        static void Main(string[] args)
        {
            GetGuestInfo();
            PrintGuestInfo();

            Console.ReadLine();
        }

        private static void GetGuestInfo()
        {
            string moreGuestComming = "";

            do
            {
                GuestBookModel guest = new GuestBookModel();

                Console.Write("What is your first name: ");
                guest.FirstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                guest.LastName = Console.ReadLine();

                Console.Write("Would you like to tell the host anything: ");
                guest.MessageToHost = Console.ReadLine();

                guests.Add(guest);

                Console.Write("Are there any more guests comming (yes/no): ");
                moreGuestComming= Console.ReadLine();

                Console.Clear();

            } while (moreGuestComming.ToLower() == "yes");
        }

        private static void PrintGuestInfo()
        {
            foreach (GuestBookModel guest in guests)
            {
                Console.WriteLine(guest.DisplayGuestInfo);
            }
        }
    }
}
