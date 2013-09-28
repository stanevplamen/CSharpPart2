using System;

class ArrayBinSearch
{
    static void Main()
    {
        int[] array = { 2, 4, 9, 9, 7, 1, 3, 3, 2, 9, 1, 3, 1, 8, 5, 6, 4, 6, 7, 1, 1, 1, 12, 10, 8, 8, 8 };

        Array.Sort(array);

        Console.WriteLine("The sorted array is: ");
        PrintArray(array);

        object myObjectOne = 6; // K

        int myIndex = Array.BinarySearch(array, myObjectOne);
        if (myIndex < 0)
        {
            int closestLowerIndex = ((~myIndex) - 1);
            Console.WriteLine("The object to search for ({0}) is not found. The closest lower object is at index {1}.", myObjectOne, closestLowerIndex);
            int closestLowerNumber = array[closestLowerIndex];
            Console.WriteLine("The closest lower number is: {0}", closestLowerNumber);
        }
        else
        {
            int closestLowerIndex = ((myIndex) - 1);
            Console.WriteLine("The object to search for ({0}) is at index {1}.", myObjectOne, myIndex);
            Console.WriteLine("The closest lower object is at index {0}.", closestLowerIndex);
            int? closestLowerNumber = null;
            closestLowerNumber = array[closestLowerIndex];
            if (array[closestLowerIndex] == array[myIndex])
            {
                int counter = 0;
                foreach (var c in array)
                {
                    if (c == array[closestLowerIndex])
                    {
                        if (counter - 1 < 0)
                        {
                            Console.WriteLine("There is no lower number");
                            closestLowerNumber = null;
                            Environment.Exit(0);
                        }
                        closestLowerNumber = array[counter - 1];
                        break;
                    }
                    counter++;
                }
            }
            Console.WriteLine("The closest lower number is: {0}", closestLowerNumber);
        }
    }

    private static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}