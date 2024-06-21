/* Random Countdown Challenge.
   This C# program is a fun countdown exercise. 
   It begins at 100 and decrements the count one by one. At each number,
   the program generates a random number. 
   If the countdown number and the random number are the same,
   the countdown resets to 100. 
   If they don't match, the countdown continues until it reaches 0 and the program ends,
   there's a possibility that the program could run indefinitely if the random number generator
   consistently matches the countdown number. 
   It’s a simple yet engaging way to practice programming logic and random number generation in C#.
*/


using System.Diagnostics;

namespace RandomCountdownChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Random Countdown Challenge";
            Console.ForegroundColor = ConsoleColor.White;
            Stopwatch timer = new Stopwatch();
            
      
            Random random = new Random();

            int countDownNumber = 100;
            int numberOfMatch = 0;
            

            timer.Start();
            while (countDownNumber >= 0)
            {
                int randomNumber = random.Next(0, 100);
                                  
                Console.WriteLine(countDownNumber);
                countDownNumber--;
                                          
                if (randomNumber == countDownNumber)
                {
                    Console.WriteLine("Match.. Starting over");
                    numberOfMatch++;
                    countDownNumber = 100;
                }

            }
            timer.Stop();

            Console.WriteLine();
            Console.WriteLine($"It took: {timer.ElapsedMilliseconds} milliseconds");
            Console.WriteLine($"Matches: {numberOfMatch}");

            Console.ReadLine();
        }


    }
}
