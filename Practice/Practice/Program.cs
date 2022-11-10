using System;
using System.ComponentModel;
using System.IO;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int z = 3;

            Console.WriteLine(Add(x, y));
            Console.WriteLine(Add(x, y, z));
        }

        // this method is setup for 2 numbers
        static int Add (int x, int y)
        {  
            return x + y;
        }

        // this method is setup for 3 numbers
        static int Add (int x, int y, int z)
        {
            return x + y + z;
        }
  
    }
}
