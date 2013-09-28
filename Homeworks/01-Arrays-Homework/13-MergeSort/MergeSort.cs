using System;
using System.Collections.Generic;

class MergeSortAlgorithm
{
    static int[] MergeArrays(int[] left, int[] right)
    {
        int[] result = new int[left.Length + right.Length];

        int leftIncrease = 0;
        int rightIncrease = 0;

        for (int i = 0; i < result.Length; i++)
        {
            if (rightIncrease == right.Length || ((leftIncrease < left.Length) && (left[leftIncrease] <= right[rightIncrease])))
            {
                result[i] = left[leftIncrease];
                leftIncrease++;
            }
            else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (right[rightIncrease] <= left[leftIncrease])))
            {
                result[i] = right[rightIncrease];
                rightIncrease++;
            }
        }
        return result;
    }

    static int[] MergeSort(int[] mergeSortArray)
    {
        if (mergeSortArray.Length <= 1)
        {
            return mergeSortArray;
        }

        int middle = mergeSortArray.Length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[mergeSortArray.Length - middle];

        for (int i = 0; i < middle; i++)
        {
            leftArray[i] = mergeSortArray[i];
        }

        for (int i = middle, j = 0; i < mergeSortArray.Length; i++, j++)
        {
            rightArray[j] = mergeSortArray[i];
        }

        leftArray = MergeSort(leftArray);
        rightArray = MergeSort(rightArray);
        int[] mergeArray = MergeArrays(leftArray, rightArray);
        return mergeArray;
    }

    static void Print(int[] printArray)
    {
        Console.WriteLine("The sorted array values (merge-sort algorithm) are: ");
        foreach (int c in printArray)
        {
            Console.Write("{0},", c);
        }
        Console.Write("\b;");
        Console.WriteLine();
    }

    static void Main()
    {
        int[] integersArray = { 1, 5, 7, 8, 9, 3, 5, 6, 7, -3, 12, 0 };
        int[] sortedArray = MergeSort(integersArray);

        Print(sortedArray);
    }
}

