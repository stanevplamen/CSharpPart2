using System;

class HexToDecimal
{
    static void Main()
    {
        string hex = "2FCA";
        long decimalPresentation = Convert.ToInt64(hex, 16);
        Console.WriteLine("The decimal presentation of {0} is {1}", hex, decimalPresentation);
    }
}