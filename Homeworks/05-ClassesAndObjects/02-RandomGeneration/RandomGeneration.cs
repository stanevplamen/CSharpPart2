using System;
using System.Threading;

class RandomGeneration
{
    public static int NextInt()
    {
        Random randomInt = new Random();
        int x = randomInt.Next(100, 200);
        int t = (x ^ (x << 11));
        int w = randomInt.Next(100, 200);
        checked
        {
            int result = (w = (w ^ (w >> 19)) ^ (t ^ (t >> 8)));
            return result;
        }
    }

    static void Main()
    {
        Console.WriteLine("Ten random numbers in the interval [100, 200] are: ");
        int numbersToGenerate = 10;
        Random random = new Random();
        int minimum = random.Next(100, 200);
        int maximum = minimum + random.Next(100, 200);

        for (int i = 1; i <= numbersToGenerate; i++)
        {
            checked
            {
                double newRandom = ((random.NextDouble() * (maximum - minimum) + minimum) * NextInt()) % 100 + 100;
                Console.WriteLine("{0:0.00}", newRandom);
            }
        }
    }
}

     