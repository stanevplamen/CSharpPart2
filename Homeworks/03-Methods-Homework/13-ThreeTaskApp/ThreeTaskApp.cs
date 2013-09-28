using System;
using System.Collections.Generic;

class ThreeTaskApp
{

    // ================================================ main
    static void Main()
    {
        Console.WriteLine("1 - reverse digits of a number");
        Console.WriteLine("2 - calculate the average of a sequence of integers");
        Console.WriteLine("3 - solve a linear equation ax + b = 0");
        Console.Write("Please select the number of the application would like to use: ");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                OperationOne();
                break;
            case 2:
                OperationTwo();
                break;
            case 3:
                OperationThree();
                break;

            default:
                Console.WriteLine("Invalid number");
                break;
        }
    }
    // ================================================ operation one
    static void OperationOne()
    {
        Console.Write("Please enter a number: ");
        string stringNumber = Console.ReadLine();
        int counter = 0;
        if (decimal.Parse(stringNumber) < 0)
        {
            Console.WriteLine("The number should be bigger than 0");
            return;
        }

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

    static List<char> ArrayReverser(List<char> charDigits, int lenght)
    {
        List<char> reversed = new List<char>();
        for (int i = lenght - 1; i >= 0; i--)
        {
            reversed.Add(charDigits[i]);
        }
        return reversed;
    }

    // ================================================ operation two
    static void OperationTwo()
    {
        Console.Write("You are given the numbers: ");
        List<int> numbersArray = new List<int> { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        Print(numbersArray);
        Console.Write("Please enter the first index of a sequence = ");
        int startIndex = int.Parse(Console.ReadLine());
        Console.Write("Please enter the last index of a sequence = ");
        int stopIndex = int.Parse(Console.ReadLine());
        if (startIndex >= stopIndex)
        {
            Console.WriteLine("The first index should be smaller than the last index");
        }
        else if (startIndex < stopIndex && startIndex >= 0 && stopIndex < numbersArray.Count)
        {
            int average = AverageSum(numbersArray, startIndex, stopIndex);
            Console.WriteLine("The average of the sequence is {0}", average);
        }
        else
        {
            Console.WriteLine("Some index(es) are out of range");
        }

    }

    static void Print(List<int> numbersArray)
    {
        for (int i = 0; i < numbersArray.Count; i++)
        {
            Console.Write("{0} ", numbersArray[i]);
        }
        Console.WriteLine();
    }

    static int AverageSum(List<int> numbers, int first, int second)
    {
        int counter = 0;
        int sum = 0;
        for (int i = first; i <= second; i++)
        {
            sum = sum + numbers[i];
            counter++;
        }
        int average = sum / counter;
        return average;
    }

    // ================================================ operation three
    static void OperationThree()
    {
        Console.WriteLine("Please enter the coefficients of the equasion ax + b = 0");
        Console.Write("a = ");
        decimal a = decimal.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("a should be different from 0");
            return;
        }
        Console.Write("b = ");
        decimal b = decimal.Parse(Console.ReadLine());

        decimal x = -(b / a);
        Console.WriteLine("x = {0}", x);
    }
}

