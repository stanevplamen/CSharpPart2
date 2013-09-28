using System;

class GetMaxClass
{
    static int GetMax(int one, int two)
    {
        if (one > two)
        {
            return one;
        }
        else
        {
            return two;
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter three numbers (on three rows): ");
        int[] numbersArray = new int[3];
        for (int i = 0; i < 3; i++)
        {
            numbersArray[i] = int.Parse(Console.ReadLine());
        }

        int minValue = int.MinValue;
        for (int i = 0; i < numbersArray.Length; i++)
        {
            int temp = GetMax(numbersArray[0], numbersArray[i]);
            if (minValue < temp)
            {
                minValue = temp;
            }
        }
        Console.WriteLine("The biggest number is: {0}", minValue);
    }
}
