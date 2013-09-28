using System;

class ShortBinaryPresentation
{
    static void Main()
    {
        // Just for test
        short positiveShort = 32767;
        string binaryPresentationOne = Convert.ToString(positiveShort, 2);
        Console.WriteLine("The binary presentation of positive Short integer is {0}", binaryPresentationOne.PadLeft(16, '0'));

        short negativeShort = -3260;
        string binaryPresentationTwo = Convert.ToString(negativeShort, 2);
        Console.WriteLine("The binary presentation of negative Short integer is {0}", binaryPresentationTwo.PadLeft(16, '0'));

        // The task
        Console.Write("Please enter a Short type integer: ");
        short shortToConvert = short.Parse(Console.ReadLine());
        string binaryPresentation = Convert.ToString(shortToConvert, 2);
        Console.WriteLine("The binary presentation of the given number is {0}", binaryPresentation.PadLeft(16, '0'));
    }
}

