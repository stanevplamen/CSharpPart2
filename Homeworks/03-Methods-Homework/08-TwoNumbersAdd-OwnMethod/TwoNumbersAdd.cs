using System;
using System.Collections.Generic;
using System.Threading;

class TwoBigSum
{
    // creates a number between 0 and 9
    static int GiveNumber()
    {
        Thread.Sleep(5); // for faster work with many digits, please comment this line
        Random rnd = new Random();
        int random = rnd.Next(0, 9);
        return random;
    }

    static void Main()
    {
        Console.Write("Please enter the number of digits of the first number: ");
        int firstDigits = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of digits of the second number: ");
        int secondDigits = int.Parse(Console.ReadLine());
        // load first array
        int[] firstArray = new int[firstDigits];
        for (int i = 0; i < firstDigits; i++)
        {
            firstArray[i] = GiveNumber();
        }

        // load second array
        int[] secondArray = new int[secondDigits];
        for (int i = 0; i < secondDigits; i++)
        {
            secondArray[i] = GiveNumber();
        }

        // load the result list
        List<int> summedDigits = AddBigNumbers(firstArray, secondArray);

        Console.WriteLine("The first Number is: ");
        Print(firstArray);
        Console.WriteLine("The second Number is: ");
        Print(secondArray);

        Console.WriteLine("The sum is: ");
        PrintList(summedDigits);
    }

    private static List<int> AddBigNumbers(int[] firstArray, int[] secondArray)
    {
        int firstStep = Math.Min(firstArray.Length, secondArray.Length);
        int secondStep = Math.Max(firstArray.Length, secondArray.Length);
        List<int> summedDigits = new List<int>();
        int reserveAdd = 0;

        for (int i = 0; i < firstStep; i++)
        {
            int currentDigitSum = firstArray[i] + secondArray[i];
            int currentRemainder = currentDigitSum % 10;
            if (reserveAdd + currentRemainder < 10)
            {
                summedDigits.Add(reserveAdd + currentRemainder);
                reserveAdd = currentDigitSum / 10;
            }
            else
            {
                summedDigits.Add(0);
                reserveAdd = currentDigitSum / 10 + 1;
            }
        }
        for (int i = firstStep + 1; i < secondStep; i++)
        {
            if (secondStep == firstArray.Length)
            {
                int currentDigitSum = firstArray[i];

                if (reserveAdd + currentDigitSum < 10)
                {
                    summedDigits.Add(reserveAdd + currentDigitSum);
                    reserveAdd = currentDigitSum / 10;
                }
                else
                {
                    summedDigits.Add(0);
                    reserveAdd = currentDigitSum / 10 + 1;
                }
            }
            else
            {
                int currentDigitSum = secondArray[i];

                if (reserveAdd + currentDigitSum < 10)
                {
                    summedDigits.Add(reserveAdd + currentDigitSum);
                    reserveAdd = currentDigitSum / 10;
                }
                else
                {
                    summedDigits.Add(0);
                    reserveAdd = currentDigitSum / 10 + 1;
                }
            }
        }
        if (reserveAdd > 0)
        {
            summedDigits.Add(reserveAdd);
        }
        return summedDigits;
    }

    private static void Print(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }

    private static void PrintList(List<int> summedDigits)
    {
        for (int i = summedDigits.Count - 1; i >= 0; i--)
        {
            Console.Write(summedDigits[i]);
        }
        Console.WriteLine();
    }
}
