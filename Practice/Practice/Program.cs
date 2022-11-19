using System;
using System.Threading;


namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            // Console.WriteLine(mainThread.Name);

            CountDown();
            CountUp();

            Console.WriteLine(mainThread.Name + " is completed!");
                 
            Console.ReadLine();
        }

        public static void CountDown()
        {
            for (int i = 5; i >=0; i--)
            {
                Console.WriteLine("Timer # 1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer # 1 is completed");
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Timer # 2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer # 2 is completed");
        }


    }
}

