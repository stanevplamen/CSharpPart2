using System;

class SequenseEqualToSum
{
    static void Main()
    {
        int[] intArray = { 4, 3, 4, 1, 4, 2, 5, 8, 2, 4, 5 };

        //Console.Write("Please enter an integer number (sum to check) = ");
        //int sumToCheck = int.Parse(Console.ReadLine());
        int sumToCheck = 11;
        int checkSum = 0;
        int[] positionsArray = new int[intArray.Length];
        int counter = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            checkSum = 0;
            for (int j = i; j < intArray.Length; j++)
            {
                checkSum = checkSum + intArray[j];
                if (checkSum == sumToCheck)
                {
                    positionsArray[i] = i + 1;
                    counter++;
                }
                else if (checkSum > sumToCheck)
                {
                    break;
                }
            }
        }

        Console.WriteLine(new string('-', 30));
        Console.WriteLine("The subsequent elements which sum is equal to the requested sum ({0}) are: ", sumToCheck);
        Console.WriteLine(new string('-', 30));
        int position = 0;
        int currentSum = 0;

        for (int p = 0; p < intArray.Length; p++)
        {
            currentSum = 0;
            if (positionsArray[p] != 0)
            {
                Console.Write("{");
                position = positionsArray[p] - 1;
                for (int g = position; g < intArray.Length; g++)
                {
                    currentSum = currentSum + intArray[g];
                    if (currentSum <= sumToCheck)
                    {
                        Console.Write("{0}, ", intArray[g]);
                    }
                    else if (currentSum > sumToCheck)
                    {
                        break;
                    }
                }
                Console.Write("\b\b}\n");
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}

