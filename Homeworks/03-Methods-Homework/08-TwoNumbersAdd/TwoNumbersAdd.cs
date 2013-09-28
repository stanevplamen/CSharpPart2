using System;
using System.Numerics;
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
    // converts the array to string (number)
    static BigInteger NumbersToString(int[] elements, int length)
    {
        string temp = null;
        string outputString = null;
        for (int i = length - 1; i >= 0; i--)
        {
            temp = elements[i].ToString("0");
            outputString = outputString + temp;
        }
        BigInteger outputNumber = BigInteger.Parse(outputString);
        return outputNumber;
    }

    static void Main()
    {
        Console.Write("Please enter the number of digits of the first number: ");
        int firstDigits = int.Parse(Console.ReadLine());
        Console.Write("Please enter the number of digits of the second number: ");
        int secondDigits = int.Parse(Console.ReadLine());
        // load first number
        int[] firstArray = new int[firstDigits];
        for (int i = 0; i < firstDigits; i++)
        {
            firstArray[i] = GiveNumber();
        }
        BigInteger fullFirstNumber = NumbersToString(firstArray, firstDigits);

        // load second number
        int[] secondArray = new int[secondDigits];
        for (int i = 0; i < secondDigits; i++)
        {
            secondArray[i] = GiveNumber();
        }
        BigInteger fullSecondNumber = NumbersToString(secondArray, secondDigits);

        Console.WriteLine("The first Number is: {0}", fullFirstNumber);
        Console.WriteLine("The second Number is: {0}", fullSecondNumber);
        Console.WriteLine("The sum is: {0}", fullFirstNumber + fullSecondNumber);
    }
}
