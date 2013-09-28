using System;
using System.Collections.Generic;

class LastDigit
{
    static string NumberToText(string lastDigit)
    {
        switch (lastDigit)
        {
            case "0":
                return "zero";
            case "1":
                return "one";
            case "2":
                return "two";
            case "3":
                return "three";
            case "4":
                return "four";
            case "5":
                return "five";
            case "6":
                return "six";
            case "7":
                return "seven";
            case "8":
                return "eight";
            case "9":
                return "nine";
            default:
                return "Invalid number";
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter a number");
        string stringNumber = Console.ReadLine();
        int counter = 0;

        List<string> charArray = new List<string>();
        foreach (char ch in stringNumber)
        {
            charArray.Add(Convert.ToString(ch));
            counter++;
        }
        string result = NumberToText(charArray[counter - 1]);
        Console.WriteLine("The last digit is {0}", result);
    }
}

