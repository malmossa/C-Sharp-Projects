
namespace MethodHomework
{
    public class Greeting
    {
        public static string GetUserName()
        {
            Console.Write("What is you name? ");
            string name = Console.ReadLine();
            return name;
        }

        public static void SayHello()
        {
            Console.WriteLine($"Hello, {GetUserName()}");
        }

        public static void Welcome()
        {
            SayHello();
        }
    }
}
