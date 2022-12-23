namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string firstNumberText = Console.ReadLine();

            Console.Write("Enter second number: ");
            string seconNumberText = Console.ReadLine();

            int number1 = int.Parse(firstNumberText);
            int number2 = int.Parse(seconNumberText);

            int add = Calculation.Add(number1, number2);
            int sub = Calculation.Sub(number1, number2);
            int mul = Calculation.Mul(number1, number2);
            
            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(mul);
            

            Console.ReadLine();

        }
    }
}











