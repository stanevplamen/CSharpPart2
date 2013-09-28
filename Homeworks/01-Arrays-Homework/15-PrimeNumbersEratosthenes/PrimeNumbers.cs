using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main()
    {
        // Print all prime numbers in the interval [n,m]
        // Slower with List

        int n = 0;
        int m = 100;
        //int n = int.Parse(Console.ReadLine());
        //int m = int.Parse(Console.ReadLine());
        int sqrtm = (int)Math.Sqrt(m) + 1;

        List<int> intFullList = new List<int>();

        for (int number = n; number <= m; number++)
        {
            intFullList.Add(number);
        }
        int divider = 2;

        while (divider <= sqrtm)
        {
            for (int j = 0; j < intFullList.Count; j++)
            {
                if (intFullList[j] % divider == 0 && divider != intFullList[j])
                {
                    intFullList.RemoveAt(j);
                    j--;
                }
            }
            divider++;
        }
        Console.WriteLine("The prime numbers in the interval [{0},{1}] are: ", n, m);
        foreach (int c in intFullList)
        {
            Console.Write("{0},", c);
        }
        Console.Write("\b;");
        Console.WriteLine();
    }
}

