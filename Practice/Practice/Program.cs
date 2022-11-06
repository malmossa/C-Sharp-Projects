using System;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a = "true";
            bool b = Convert.ToBoolean(a);

            Console.WriteLine(b);
            Console.WriteLine(b.GetType());


            Console.ReadKey();
        }
    }
}
