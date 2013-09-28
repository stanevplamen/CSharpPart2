using System;

class MaxSumElements
{
    static void Main()
    {
        int[] intArray = { 13, 3, -5, -10, -2, 17, -6, 12, -8, 9 };

        int biggerSum = 0;
        int previousSum = 0;
        int currentSum = 0;
        int memberIndication = 0;
        int count = 0;
        int counter = 0;
        bool allNegative = true;

        // Finding the sequence of maximal sum

        for (int i = 0; i < intArray.Length; i++)
        {
            if (intArray[i] >= 0)
            {
                allNegative = false;
                previousSum = currentSum;
                currentSum = currentSum + intArray[i];
                count++;
                if (biggerSum < currentSum)
                {
                    biggerSum = currentSum;
                    memberIndication = i;
                    counter = count;
                }
            }
            else if ((i - 1) >= 0 && intArray[i] < 0 && currentSum + intArray[i] < 0)
            {
                currentSum = 0;
                previousSum = 0;
                count = 0;
            }
            else if ((i - 1) >= 0 && intArray[i] < 0 && currentSum + intArray[i] > 0)
            {
                previousSum = currentSum;
                currentSum = currentSum + intArray[i];
                count++;
                if (biggerSum < currentSum)
                {
                    biggerSum = currentSum;
                    memberIndication = i;
                    counter = count;
                }
            }
        }

        if (allNegative == true)
        {
            int tempMax = int.MinValue;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (tempMax < intArray[i])
                {
                    tempMax = intArray[i];
                }
            }
            biggerSum = tempMax;
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("The maximal sum of sequential elements in the N-array is = {0} ", biggerSum);
            Console.WriteLine("he sequential elements with the max sum are: {0}", biggerSum);
            Console.WriteLine(new string('-', 30));
            Environment.Exit(0);
        }
        // Print 

        Console.WriteLine(new string('-', 30));
        Console.WriteLine("The maximal sum of sequential elements in the N-array is = {0} ", biggerSum);

        Console.Write("The sequential elements with the max sum are: {");
        for (int i = memberIndication - counter + 1; i <= memberIndication + 1; i++)
        {
            if (biggerSum > 0)
            {
                Console.Write("{0}, ", intArray[i]);
                biggerSum = biggerSum - intArray[i];
            }
            else if (biggerSum < 0)
            {
                break;
            }
        }
        Console.Write("\b\b}\n");
        Console.WriteLine(new string('-', 30));
    }
}

