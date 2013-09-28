using System;
using System.Collections.Generic;

class PrimeNumbers
{
    static void Main()
    {
        // Print all prime numbers in the interval [n, m]
        // Faster - direct calculation
        int n = 0;
        int m = 10000000;
        List<int> intFullList = new List<int>();
        for (int number = 0; number <= m; number++)
        {
            bool prime = true;
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);

            while (divider <= maxDivider) 
            {
                if (number % divider == 0) 
                {
                    prime = false;
                    break;
                }
                divider++;
            }
            if (prime) // true
            {
                intFullList.Add(number);
            }
        }
        Console.WriteLine("The prime numbers in the interval [{0},{1}] are: ", n, m);
        for (int i = 0; i < intFullList.Count; i++)
        {
            Console.Write("{0 }", intFullList[i]);
        }
    }
}
