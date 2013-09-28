using System;
using System.Text;

class ReverseString
{
    static string ReverseMethod(string toReverse)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = toReverse.Length - 1; i >= 0; i--)
        {
            sb.Append(toReverse[i]);
        }
        string reversed = sb.ToString();
        return reversed;
    }

    static void Main()
    {
        string beforeReverse = "*123456789$";
        string afterReverse = ReverseMethod(beforeReverse);
        Console.WriteLine("The input string is:{0}\nThe reversed string is {1}", beforeReverse, afterReverse);
    }
}

