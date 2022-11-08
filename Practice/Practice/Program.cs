using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String fullName = "mansor almossa";

            String phoneNumber = "626-629-4225";

            // fullName = fullName.ToUpper();
            // fullName = fullName.ToLower();
            // Console.WriteLine(fullName);

            // phoneNumber = phoneNumber.Replace("-","/");
            // Console.WriteLine(phoneNumber);

            // String userName = fullName.Insert(0, "@");
            // Console.WriteLine(userName);

            // Console.WriteLine(fullName.Length);

            String firstName = fullName.Substring(0, 6);
            Console.WriteLine(firstName);

            Console.ReadKey();
        }
    }
}
