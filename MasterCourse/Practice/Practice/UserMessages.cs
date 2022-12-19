
namespace Practice
{
    public class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            int hourOfTheDay = DateTime.Now.Hour;

            if (hourOfTheDay < 12)
            {
                Console.WriteLine($"Good Morning {firstName}");
            } else if(hourOfTheDay < 19)
            {
                Console.WriteLine($"Good Afternoon {firstName}");
            } else
            {
                Console.WriteLine($"Good evning {firstName}");
            }
        }
    }
}
