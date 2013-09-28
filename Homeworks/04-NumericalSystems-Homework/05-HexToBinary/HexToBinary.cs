using System;
using System.Linq;

class HexToBinary
{
    static void Main()
    {
        string hexValue = "2fca";
        string binarystring = String.Join(String.Empty, hexValue.Select(
        c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
        Console.WriteLine(binarystring);
    }
}

