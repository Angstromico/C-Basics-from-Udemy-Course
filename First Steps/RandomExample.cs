using System;
using System.Collections.Generic;
using System.Text;

namespace First_Steps
{
    internal class RandomExample
    {
        public static void Run()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100
            Console.WriteLine($"Random number between 1 and 100: {randomNumber}");
        }
    }
}
