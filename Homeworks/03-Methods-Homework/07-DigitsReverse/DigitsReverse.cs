using System;
using System.Collections.Generic;

class DigitsReverse
{
    static List<char> ArrayReverser(List<char> charDigits, int lenght)
    {
        List<char> reversed = new List<char>();
        for (int i = lenght - 1; i >= 0; i--)
        {
            reversed.Add(charDigits[i]);
        }
        return reversed;
    }
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        string stringNumber = Console.ReadLine();
        int counter = 0;

        List<char> charArray = new List<char>();
        foreach (char ch in stringNumber)
        {
            charArray.Add((ch));
            counter++;
        }
        List<char> reversedArray = new List<char>();
        reversedArray = (ArrayReverser(charArray, counter));
        Console.Write("The entered number is: ");
        foreach (var numb in charArray)
        {
            Console.Write(numb);
        }
        Console.WriteLine();
        Console.Write("The reversed number is: ");
        foreach (var revNumb in reversedArray)
        {
            Console.Write(revNumb);
        }
        Console.WriteLine();
    }
}

