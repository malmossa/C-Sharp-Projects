

namespace GuestBook
{
    public class logic
    {
        int totalGuest = 0;
        public static void Welcome()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("** Welcom To The Guest Book **");
            Console.WriteLine("******************************");
        }

        public static void GetName() 
        {
            
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
   
        }

        public static int GetPartyNumber()
        {
            int partyNumber = 0;
            bool isValid = true;
            do
            {
                Console.Write("How many in your party? ");
                string partyNumberText = Console.ReadLine();

                isValid = int.TryParse(partyNumberText, out partyNumber);

            } while (!isValid);

            return partyNumber;
        }

    }
}
