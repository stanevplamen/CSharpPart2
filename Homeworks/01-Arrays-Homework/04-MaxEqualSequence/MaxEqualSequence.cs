using System;

class MaxEqualSequence
{
    static void Main()
    {
        int[] intArray = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1 };
        int counter = 1;
        int maxRepeatCounter = 1;
        int? maxRepeatNumber = null;
        for (int i = 0; i < intArray.Length - 1; i++)
        {
            if (intArray[i] == intArray[i + 1])
            {
                counter++;
            }
            else if (intArray[i] != intArray[i + 1])
            {
                if (maxRepeatCounter < counter)
                {
                    maxRepeatCounter = counter;
                    maxRepeatNumber = intArray[i - 1];
                }
                counter = 1;
            }
        }
        if (counter > maxRepeatCounter)
        {
            maxRepeatCounter = counter;
            maxRepeatNumber = intArray[intArray.Length - 1];
        }
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("The maximal sequence of equal elements is: {0} times", maxRepeatCounter);
        Console.WriteLine("The repeating number is: {0} ", maxRepeatNumber);

        Console.Write("{");
        for (int i = 1; i <= maxRepeatCounter; i++)
        {
            Console.Write("{0}, ", maxRepeatNumber);
        }
        Console.Write("\b\b}\n");
        Console.WriteLine(new string('-', 30));
    }
}

