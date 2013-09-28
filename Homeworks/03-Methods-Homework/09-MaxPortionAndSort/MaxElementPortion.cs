using System;
using System.Collections.Generic;

class MaxElementPortion
{
    // return the max number of a portion
    static int MaxMemberCount(List<int> elements, int start, int end)
    {
        int maxValue = int.MinValue;
        for (int i = start; i <= end; i++)
        {
            if (maxValue < elements[i])
            {
                maxValue = elements[i];
            }
        }
        return maxValue;
    }
    // Sort array
    static List<int> SortArray(List<int> elements)
    {
        if (elements.Count <= 1)
        {
            return elements;
        }
        int middle = elements.Count / 2;
        List<int> leftPart = new List<int>();
        List<int> rightPart = new List<int>();

        for (int i = 0; i < elements.Count; i++)
        {
            if (i < middle)
            {
                leftPart.Add(elements[i]);
            }
            else
            {
                rightPart.Add(elements[i]);
            }
        }

        leftPart = SortArray(leftPart);
        rightPart = SortArray(rightPart);

        return Merge(leftPart, rightPart);
    }

    // Merge array
    static List<int> Merge(List<int> left, List<int> right)
    {
        int start = 0;
        List<int> result = new List<int>();
        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                int leftInt = MaxMemberCount(left, start, left.Count - 1);
                int rightInt = MaxMemberCount(right, start, right.Count - 1);
                if (leftInt <= rightInt)
                {
                    result.Add(left[start]);
                    left.RemoveAt(start);
                }
                else
                {
                    result.Add(right[start]);
                    right.RemoveAt(start);
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left[start]);
                left.RemoveAt(start);
            }
            else if (right.Count > 0)
            {
                result.Add(right[start]);
                right.RemoveAt(start);
            }
        }
        return result;
    }


    static void Main()
    {
        List<int> numbersArray = new List<int> { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

        int startIndex = 4;
        int endIndex = 9;

        int maxNumber = MaxMemberCount(numbersArray, startIndex, endIndex);
        Console.WriteLine("The max value between {0} and {1} members is {2}", startIndex, endIndex, maxNumber);

        List<int> sortedArray = SortArray(numbersArray);
        Console.WriteLine("The unsorted array is: ");
        Print(numbersArray);
        Console.WriteLine("The sorted array is: ");
        Print(sortedArray);
    }

    private static void Print(List<int> sortedArray)
    {
        foreach (int c in sortedArray)
        {
            Console.Write("{0} ", c);
        }
        Console.WriteLine();
    }
}

