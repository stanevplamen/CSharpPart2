using System;

class SelectionSortArray
{
    static void Main()
    {
        int[] arrayToSort = { 64, 25, 12, 22, 11, 33, 44, 55, 3, 2, 0, -5 };

        int i;
        int iMin;

        for (int j = 0; j < arrayToSort.Length - 1; j++)
        {
            /* така си гарантираме че няма пак да вземен вече подреден елемент */
            iMin = j;
            for (i = j + 1; i < arrayToSort.Length; i++)
            {
                /* намираме най-малкия елемент */
                if (arrayToSort[i] < arrayToSort[iMin])
                {
                    /* запомняме индекса */
                    iMin = i;
                }
            }

            /* подреждаме масива във възходящ ред, като винаги разменяме позицията на най-малкия следващ елемент */
            if (iMin != j)
            {
                int temp = arrayToSort[iMin];
                arrayToSort[iMin] = arrayToSort[j];
                arrayToSort[j] = temp;
            }
        }

        Console.WriteLine(new string('-', 30));
        Console.Write("The sorted array is: {");
        for (int p = 0; p < arrayToSort.Length; p++)
        {
            Console.Write("{0}, ", arrayToSort[p]);
        }
        Console.Write("\b\b}\n");
        Console.WriteLine(new string('-', 30));
    }
}



