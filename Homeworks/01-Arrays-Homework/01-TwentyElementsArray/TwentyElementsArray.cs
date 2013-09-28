using System;

class TwentyElementsArray
{
    static void Main()
    {
        int[] twentyElements = new int[20];

        for (int i = 0; i < 20; i++)
        {
            twentyElements[i] = i * 5;
            Console.WriteLine("The element {0} = {1}", i, twentyElements[i]);
        }
    }
}

