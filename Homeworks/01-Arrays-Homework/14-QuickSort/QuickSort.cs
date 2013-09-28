using System;
using System.Collections.Generic;

class QuickSortStrings
{
    static void Main()
    {
        // (sort by the first letter)
        List<string> arrayList = new List<string> { "ppp7", "ttt8", "xxx9", "zzz10", "bbb2", "aaa1", "ccc3", "ddd4", "eee5", "fff6" };
        Console.WriteLine("The current strings array is: ");
        foreach (var item in arrayList)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();

        List<string> sortedArrayList = QuickSortFunction(arrayList);

        Console.WriteLine("The sorted strings array is: ");
        foreach (var item in sortedArrayList)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }

    static List<string> QuickSortFunction(List<string> currentArrayList)
    {
        if (currentArrayList.Count <= 1)
        {
            return currentArrayList;
        }

        int measuringSign = currentArrayList.Count / 2;
        string valueSign = currentArrayList[measuringSign];
        currentArrayList.RemoveAt(measuringSign);

        List<string> smaller = new List<string>();
        List<string> bigger = new List<string>();

        int counter = 0;
        foreach (var item in currentArrayList)
        {
            if (true)
            {
                if (string.Compare(item, valueSign) < 0)
                {
                    smaller.Add(item);
                }
                else
                {
                    bigger.Add(item);
                }
            }
            counter++;
        }
        List<string> resultArrayList = new List<string>();
        resultArrayList.AddRange(QuickSortFunction(smaller));
        resultArrayList.Add(valueSign);
        resultArrayList.AddRange(QuickSortFunction(bigger));
        return resultArrayList;
    }
}

