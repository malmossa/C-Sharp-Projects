
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();
            
            UserMessages.ApplicationStartMessage(firstName);

            double x = RequestData.GetDouble("Enter first number: ");
            double y = RequestData.GetDouble("Enter second number: ");

            Console.WriteLine(CalculateData.Add(x, y));


            Console.ReadLine();
        }

      
    }
}






