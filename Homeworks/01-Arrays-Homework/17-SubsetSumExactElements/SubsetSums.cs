using System;
using System.Collections.Generic;

class SubsetSums
{
    static void Main()
    {
        Console.Write("Please enter the subset sum to check S = ");
        int checkedSum = int.Parse(Console.ReadLine());
        Console.Write("Please enter the lenght of the array N = ");
        int arrayLenght = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of summed elements to check K = ");
        int k = int.Parse(Console.ReadLine());
        long[] nArray = new long[arrayLenght];
        Console.WriteLine("Please enter the elements on separate rows");
        for (int i = 0; i < arrayLenght; i++)
        {
            nArray[i] = long.Parse(Console.ReadLine());
        }

        int counter = 0;
        int counterTwo = 0;
        long currentSum = 0;
        List<long> intList = new List<long>();
        long iterationsNumber = (long)Math.Pow((double)2, nArray.Length);

        Console.WriteLine("The {1} elements which sum is equal to the requested sum ({0}) are: ", checkedSum, k);
        for (int i = 1; i <= (iterationsNumber - 1); i++)
        {
            counterTwo = 0;
            currentSum = 0;
            for (int j = 0; j < nArray.Length; j++)
            {
                long mask = 1 << j;
                long nAndMask = mask & i;
                long bit = nAndMask >> j;

                if (bit == 1)
                {
                    currentSum = currentSum + nArray[j];
                    intList.Add(nArray[j]);
                    counterTwo++;
                }
            }
            if (currentSum == checkedSum && counterTwo == k)
            {
                foreach (int c in intList)
                {
                    Console.Write("{0},", c);
                }
                Console.Write("\b;");
                Console.WriteLine();
                counter++;
                intList = new List<long>();
            }
            else
            {
                intList = new List<long>();
            }
        }
        if (counter == 0)
        {
            Console.WriteLine("There are no {0} elements which have sum {1}", k, checkedSum);
        }
    }
}
