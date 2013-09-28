// float and double to binary string and then the binary back to decimal number

using System;

class FloatToBinaryAndBack
{
    static void Main()
    {
        double d1 = 1234.5678;
        string ds = DoubleToBinaryString(d1);
        double d2 = BinaryStringToDouble(ds);

        float f1 = -1321.1f;
        string fs = SingleToBinaryString(f1);
        float f2 = BinaryStringToSingle(fs);

        Console.WriteLine("The double number:" + d1);
        Console.WriteLine("To binary (str):" + ds);
        Console.WriteLine("Back to number: " + d2);
        Console.WriteLine();
        Console.WriteLine("The double number:" + f1);
        Console.WriteLine("To binary (string): " + fs);
        Console.WriteLine("Back to number: " + f2);
    }

    public static string DoubleToBinaryString(double d)
    {
        return Convert.ToString(BitConverter.DoubleToInt64Bits(d), 2).PadLeft(64, '0');
    }

    public static double BinaryStringToDouble(string s)
    {
        return BitConverter.Int64BitsToDouble(Convert.ToInt64(s, 2));
    }

    public static string SingleToBinaryString(float f)
    {
        byte[] b = BitConverter.GetBytes(f);
        int i = BitConverter.ToInt32(b, 0);
        return Convert.ToString(i, 2).PadLeft(32, '0');
    }

    public static float BinaryStringToSingle(string s)
    {
        int i = Convert.ToInt32(s, 2);
        byte[] b = BitConverter.GetBytes(i);
        return BitConverter.ToSingle(b, 0);
    }
}

