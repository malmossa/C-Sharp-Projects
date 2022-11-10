using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = 20;
            String message;

           /* if (temperature >= 15)
            {
                message = "It's warm outside!";
            } else
            {
                message = "It's cold outside!";
            }
           */

           // this will be the same 
            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";

            Console.WriteLine(message);
        }

       

    }
}
