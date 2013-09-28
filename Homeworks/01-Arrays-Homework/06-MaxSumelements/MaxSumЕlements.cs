using System;

class MaxSumElements
{
    static void Main()
    {
        /*за по бърз тест директно деклрирам масива, ако се чете от конзолата, решението е
        
        int arrayLength = int.Parse(Console.ReadLine());
        int[] intArray = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
        }
         */

        int[] intArray = { 2, 40, 1, 2, 3, 3, 2, 2, 2, 1, 1, 1, 1, 10, 100 };

        Console.Write("Please enter the number of max sum checked elements K (K < N) = ");
        int sumElements = int.Parse(Console.ReadLine());
        int biggerSum = 0;
        int lastPosition = 0;
        int tempPosition = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            int tempSum = 0;
            if (i + sumElements <= intArray.Length)
            {
                for (int j = i; j < i + sumElements; j++)
                {
                    tempSum = tempSum + intArray[j];
                    tempPosition = j;
                }
                if (biggerSum < tempSum)
                {
                    biggerSum = tempSum;
                    lastPosition = tempPosition;
                }
            }
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine("The maximal sum of {0} sequential elements in the N-array is = {1} ", sumElements, biggerSum);

        Console.Write("{");
        for (int i = lastPosition - sumElements + 1; i <= lastPosition; i++)
        {
            Console.Write("{0}, ", intArray[i]);
        }
        Console.Write("\b\b}\n");
        Console.WriteLine(new string('-', 30));
    }
}

