using System;

class MaxEqualSequence
{
    static void Main()
    {
        // It will be the same algoritum as a task 04 but with additional sorting of the elements in the array
        int[] intArray = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1, 1, 1, 1, 1, 1 };
        int counter = 1;
        int maxRepeatCounter = 1;
        int? maxRepeatNumber = null;
        Array.Sort(intArray);
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
        Console.WriteLine("The most frequent number is: {0} ", maxRepeatNumber);
        Console.WriteLine("It is repeating: {0} times", maxRepeatCounter);
        Console.WriteLine(new string('-', 30));
    }
}

