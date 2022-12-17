
namespace GuestBook
{
    public static class GuestLogic
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Wolcome to the Guest Book App");
            Console.WriteLine("*****************************\n");
        }

        public static string GetPartyName()
        {
            Console.Write("What is your Party/Group name: ");
            string output = Console.ReadLine();

            return output;
        }

        public static int GetPartySize()
        {
            bool isValidNumber;
            int output;
            do
            {
                Console.Write("How many people are in your party: ");
                string partySizeText = Console.ReadLine();

                isValidNumber = int.TryParse(partySizeText, out output); 
            } while (!isValidNumber);

            return output;
        }
     }
}
