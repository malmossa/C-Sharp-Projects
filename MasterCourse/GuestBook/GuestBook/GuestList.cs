
namespace GuestBook
{
    public class GuestList
    {

        public static void GetGuestNamesAndNumbers()
        {
            List<string> names = new List<string>();
            int totalGuests = 0;
            bool anyMore = true;

            do
            {
                Console.Write("What is your name? ");
                names.Add(Console.ReadLine().ToUpper());

                Console.Write("How many in your party? ");
                int number = int.Parse(Console.ReadLine());
                totalGuests += number;

                Console.Write("Any more? (y/n)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "n")
                {
                    anyMore = false;
                    Console.WriteLine("Thank you for comming..");
                }

            } while (anyMore);

            Console.WriteLine("--------------------------\n");

            foreach (string name in names)
            {
                Console.WriteLine($"Guest: {name}");
            }

            Console.WriteLine($"Total Guests: {totalGuests}");

        }
    }

}
