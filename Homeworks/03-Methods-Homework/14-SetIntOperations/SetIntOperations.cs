using System;
using System.Threading.Tasks;
using System.Threading;

class SetIntOperations
{
    // creates a number between 3 and 12
    static int GiveNumber()
    {
        Random rnd = new Random();
        Thread.Sleep(150); // wait to generate different number
        int random = rnd.Next(3, 12);
        return random;
    }

    // calculate the max, min , sum and product
    static int[] MaxMinSum(int[] elements)
    {
        int[] output = new int[5]; // here will be copied the five int results
        output[0] = int.MinValue;
        output[1] = int.MaxValue;
        output[2] = 0;
        output[3] = 1;
        int i = 0;
        for (i = 0; i < elements.Length; i++)
        {
            if (output[0] < elements[i])
            {
                output[0] = elements[i];
            }
            if (output[1] > elements[i])
            {
                output[1] = elements[i];
            }
            output[2] = output[2] + elements[i];
            output[3] = output[3] * elements[i];
        }
        output[4] = output[2] / i;
        return output;
    }

    static void Main()
    {
        // declare the set of integers
        int length = GiveNumber();
        int[] setOfNumbers = new int[length];

        for (int i = 0; i < setOfNumbers.Length; i++)
        {
            //Console.Write("Please enter the {0} member value: ", i);
            setOfNumbers[i] = GiveNumber(); //int.Parse(Console.ReadLine());
        }

        int[] results = MaxMinSum(setOfNumbers);

        PrintSet(setOfNumbers);
        PrintAnsw(results);
    }

    private static void PrintSet(int[] setOfNumbers)
    {
        Console.Write("The given set is: ");
        foreach (var c in setOfNumbers)
        {
            Console.Write("{0} ", c);
        }
        Console.WriteLine();
    }

    private static void PrintAnsw(int[] results)
    {
        Console.WriteLine("The max value is: {0}", results[0]);
        Console.WriteLine("The min value is: {0}", results[1]);
        Console.WriteLine("The average is: {0}", results[4]);
        Console.WriteLine("The sum is: {0}", results[2]);
        Console.WriteLine("The product is: {0}", results[3]);
    }
}

