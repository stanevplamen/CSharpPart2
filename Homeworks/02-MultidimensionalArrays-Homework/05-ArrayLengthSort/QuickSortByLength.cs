using System;
using System.Collections.Generic;

class QuickSortByLength
{
    static List<int> QuickSortEmpement(List<int> unsortedList)
    {
        if (unsortedList.Count <= 1)
        {
            return unsortedList;
        }
        int pivot = unsortedList.Count / 2;
        int pivotValue = unsortedList[pivot];
        unsortedList.RemoveAt(pivot);
        List<int> lesser = new List<int>();
        List<int> greater = new List<int>();
        foreach (int element in unsortedList)
        {
            if (element <= pivotValue)
            {
                lesser.Add(element);
            }
            else
            {
                greater.Add(element);
            }
        }
        List<int> result = new List<int>();
        result.AddRange(QuickSortEmpement(lesser));
        result.Add(pivotValue);
        result.AddRange(QuickSortEmpement(greater));
        return result;
    }

    static void Main()
    {
        List<string> arrayList = new List<string> { "wwwww5", "zzzz4", "ccc3", "ss2", "hhh3", "a1" };
        List<int> array = new List<int>();

        int counterChar = 0;
        int counterString = 0;
        foreach (string str in arrayList)
        {
            foreach (char c in str)
            {
                counterChar++;
            }
            array.Add(counterChar);
            counterString++;
            counterChar = 0;
        }

        List<int> sortedArray = QuickSortEmpement(array);

        counterChar = 0;
        counterString = 0;
        foreach (var item in sortedArray)
        {
            foreach (string str in arrayList)
            {
                counterChar = 0;
                foreach (char c in str)
                {
                    counterChar++;
                }
                array.Add(counterChar);
                if (counterChar == item && sortedArray[counterString] != sortedArray[counterString + 1])
                {
                    Console.WriteLine(str);
                }
            }
            counterString++;
            if (counterString + 1 == sortedArray.Count)
            {
                counterString--;
            }
        }
    }
}

