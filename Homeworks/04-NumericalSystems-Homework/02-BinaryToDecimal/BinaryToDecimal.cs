using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binary = "1111011";
        long decimalPresentation = Convert.ToInt64(binary, 2);
        Console.WriteLine("The decimal presentation of {0} is {1}", binary, decimalPresentation);
    }
}
