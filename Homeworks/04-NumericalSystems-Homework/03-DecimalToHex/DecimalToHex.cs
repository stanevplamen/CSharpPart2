using System;

class DecimalToHex
{
    static void Main()
    {
        int decimalNumber = 12234;
        string hexPresentation = Convert.ToString(decimalNumber, 16);
        Console.WriteLine("The hexadecimal presentation of {0} is {1}", decimalNumber, hexPresentation);
    }
}

