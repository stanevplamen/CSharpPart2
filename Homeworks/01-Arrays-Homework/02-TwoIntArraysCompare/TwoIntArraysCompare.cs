using System;

class TwoArraysCompare
{
    static void Main()
    {
        Console.Write("Please enter the length of the Array #1: ");
        int arrayOneLength = int.Parse(Console.ReadLine());

        Console.Write("Please enter the length of the Array #2: ");
        int arrayTwoLength = int.Parse(Console.ReadLine());

        int[] arrayOne = new int[arrayOneLength];
        int[] arrayTwo = new int[arrayTwoLength];

        for (int i = 0; i < arrayOneLength; i++)
        {
            Console.Write("( Array #1) Please enter the value of the {0} element: ", i);
            arrayOne[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrayTwoLength; i++)
        {
            Console.Write("( Array #2) Please enter the value of the {0} element: ", i);
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }

        if (arrayOneLength == arrayTwoLength)
        {
            for (int i = 0; i < arrayOneLength; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 value: {1} = Array #2 value: {2}", i, arrayOne[i], arrayTwo[i]);
                }
                else if (arrayOne[i] > arrayTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 value: {1} > Array #2 value: {2}", i, arrayOne[i], arrayTwo[i]);
                }
                else if (arrayOne[i] < arrayTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 value: {1} < Array #2 value: {2}", i, arrayOne[i], arrayTwo[i]);
                }
            }
        }
        else if (arrayOneLength > arrayTwoLength)
        {
            for (int i = 0; i < arrayTwoLength; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 value: {1} = Array #2 value: {2}", i, arrayOne[i], arrayTwo[i]);
                }
                else if (arrayOne[i] > arrayTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 value: {1} > Array #2 value: {2}", i, arrayOne[i], arrayTwo[i]);
                }
                else if (arrayOne[i] < arrayTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 value: {1} < Array #2 value: {2}", i, arrayOne[i], arrayTwo[i]);
                }
            }

            for (int i = arrayTwoLength; i < arrayOneLength; i++)
            {
                Console.WriteLine("Element {0} : Array #1 value: {1} > Array #2 value: no element (null)", i, arrayOne[i]);
            }
        }

        else if (arrayOneLength < arrayTwoLength)
        {
            for (int i = 0; i < arrayOneLength; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 value: {1} = Array #2 value: {2}", i, arrayOne[i], arrayTwo[i]);
                }
                else if (arrayOne[i] > arrayTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 value: {1} > Array #2 value: {2}", i, arrayOne[i], arrayTwo[i]);
                }
                else if (arrayOne[i] < arrayTwo[i])
                {
                    Console.WriteLine("Element {0} : Array #1 value: {1} < Array #2 value: {2}", i, arrayOne[i], arrayTwo[i]);
                }
            }

            for (int i = arrayOneLength; i < arrayTwoLength; i++)
            {
                Console.WriteLine("Element {0} : Array #1 value: no element (null) < Array #2 value: {1}", i, arrayTwo[i]);
            }
        }
    }
}

