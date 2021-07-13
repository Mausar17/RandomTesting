using System;

namespace RandomTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("How many times should I repeat this?");
            int timesRepeated = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < timesRepeated; i++)
            {
                int randomInt = random.Next();
                Console.WriteLine("Random integer: " + randomInt);

                int zeroToNine = random.Next(10);
                Console.WriteLine("Random number from 0 to 9: " + zeroToNine);

                int dieRoll = random.Next(1, 7);
                Console.WriteLine("Simulated die roll: " + dieRoll);

                double randomDouble = random.NextDouble(); //only between 0.0 and 1.0
                Console.WriteLine("Random double multiplied by 100: " + randomDouble * 100); //multiply to get bigger numbers.

                Console.WriteLine("Same double but casted to a float: " + (float)randomDouble * 100F);
                Console.WriteLine("Same double but casted to a decimal: " +(decimal)randomDouble * 100M);

                int zeroOrOne = random.Next(2);
                bool coinFlip = Convert.ToBoolean(zeroOrOne);
                Console.WriteLine("Coinflip simulation from value of 0 or 1: " + coinFlip);
            }
            
        }
    }
}
