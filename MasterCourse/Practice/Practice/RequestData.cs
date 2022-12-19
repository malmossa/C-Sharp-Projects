

namespace Practice
{
    public class RequestData
    {
       
        public static double GetDouble(string message)
        {
            Console.Write(message);
            string doubleText = Console.ReadLine();
            int doubleNumber = int.Parse(doubleText);

            return doubleNumber;
        }
    }
}
