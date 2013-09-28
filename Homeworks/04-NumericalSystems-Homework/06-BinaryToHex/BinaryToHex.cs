using System;

class BinaryToHex
{
    static void Main()
    {
        string bin = "1011000001111";

        int rest = bin.Length % 4;  //  the program goes by groups of four and convert them seperately
        if (rest != 0)
            bin = new string('0', 4 - rest) + bin; //pad the length out to by divideable by 4

        string output = "";

        for (int i = 0; i <= bin.Length - 4; i += 4)
        {
            output += string.Format("{0:X}", Convert.ToByte(bin.Substring(i, 4), 2));
        }
        Console.WriteLine(output);
    }
}

