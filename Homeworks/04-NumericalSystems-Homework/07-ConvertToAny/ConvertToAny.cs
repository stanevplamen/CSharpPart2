using System;
using System.Collections.Generic;

class ConvertToAnyNumSystem
{
    static string numberToConvert;

    static void Main()
    {
        Console.Write("Please enter the base of the first numerical system (s) 1<S<17 = ");
        byte s = byte.Parse(Console.ReadLine());

        Console.Write("Please enter the number to convert: ");
        numberToConvert = (Console.ReadLine().ToUpper()); // "123".ToUpper();

        // Convert the number into decimal system
        int numberInDecimal = ConvertToDecimal(numberToConvert, s);
        // The number in decimal system is numberInDecimal

        // Convert the decimal number to the second numerical system
        Console.Write("Please enter the base of the second numerical system (d) 1<D<17 = ");
        byte d = byte.Parse(Console.ReadLine());

        List<int> listNumbers = (ConvertToAny(numberInDecimal, d));
        List<char> listChars = (ConvertToChar(listNumbers));

        Print(listChars);
    }

    // first step - convert to decimal
    private static int ConvertToDecimal(string numberToConvert, byte s)
    {
        int conterPow = numberToConvert.Length - 1;
        int numberInDecimal = 0;
        foreach (char c in numberToConvert)
        {
            // if the current char is letter - convert it to number
            int charNumb = CharConvert(c);
            // check if the number is valid and convert to decimal
            if (charNumb < s)
            {
                numberInDecimal = numberInDecimal + charNumb * (int)Math.Pow(s, conterPow);
                conterPow--;
            }
            else
            {
                Console.WriteLine("The number not belongs to the numerical system");
                Environment.Exit(0);
            }
        }
        return (numberInDecimal);
    }

    private static int CharConvert(char c)
    {
        int number;
        switch (c)
        {
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                return (number = (int)Char.GetNumericValue(c));
            case 'A':
                return (10);
            case 'B':
                return (11);
            case 'C':
                return (12);
            case 'D':
                return (13);
            case 'E':
                return (14);
            case 'F':
                return (15);

            default:
                Console.WriteLine("Invalid number");
                return (16);
        }
    }

    //second step - convert to given numerical system
    private static List<int> ConvertToAny(int number, byte d)
    {
        List<int> listNumbers = new List<int>();

        while (number > 0)
        {
            listNumbers.Add(number % d);
            number = number / d;
        }

        listNumbers.Reverse();

        return listNumbers;
    }

    private static List<char> ConvertToChar(List<int> listNumbers)
    {
        List<char> listChars = new List<char>();
        foreach (int numb in listNumbers)
        {
            switch (numb)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    listChars.Add((char)(numb + 48));
                    break;
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    listChars.Add((char)(numb + 55));
                    break;

                default:
                    break;
            }
        }
        return listChars;
    }

    private static void Print(List<char> listChars)
    {
        Console.Write("The number presented in the second numerical system is: ");
        foreach (char c in listChars)
        {
            Console.Write(c);
        }
        Console.WriteLine();
    }
}

