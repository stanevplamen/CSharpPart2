using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        int[] intArray = { 1, 2, 3, 4, 5, -1, 2, 3, 4, -4, -1, 0, 1, 2, 3 };
        int counter = 1;
        int maxRepeatCounter = 1;
        int? lastRepeatNumber = null;
        int index = 0;
        for (int i = 0; i < intArray.Length - 1; i++)
        {
            if (intArray[i] + 1 <= intArray[i + 1])
            {
                counter++;
            }
            else if (intArray[i] + 1 > intArray[i + 1])
            {
                if (maxRepeatCounter < counter)
                {
                    maxRepeatCounter = counter;
                    lastRepeatNumber = intArray[i];
                    index = i;
                }
                counter = 1;
            }
        }
        if (counter > maxRepeatCounter)
        {
            maxRepeatCounter = counter;
            lastRepeatNumber = intArray[intArray.Length - 1];
            index = intArray.Length - 1;
        }
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("The maximal sequence of increasing elements is: {0} times", maxRepeatCounter);

        Console.Write("{");
        for (int i = maxRepeatCounter; i >= 1; i--)
        {
            Console.Write("{0}, ", (intArray[index + 1 - i]));
        }
        Console.Write("\b\b}\n");
        Console.WriteLine(new string('-', 30));
    }
}

