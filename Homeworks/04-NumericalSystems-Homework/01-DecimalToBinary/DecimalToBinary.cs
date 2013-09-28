using System;

class DecimalToBinary
{
    static void Main()
    {
        int decimalNumber = 11179;
        string binaryPresentation = Convert.ToString(decimalNumber, 2);
        Console.WriteLine("The binary presentation of {0} is {1}", decimalNumber, binaryPresentation);
    }
}