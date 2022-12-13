
namespace Practice
{
    public class Greeting
    {
        // Tuples
        public static (string, string) GetUserFullName()
        {
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            return(firstName, lastName);
            
        }
    }
}
