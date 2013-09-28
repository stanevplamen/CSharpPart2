using System;
using System.Collections.Generic;
using System.Text;

class ConsecutiveLetters
{
    static string someText = "aaaaabbbbbcdddeeeedssaa".ToLower();

    static string LettersCount()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < someText.Length; i++)
        {
            int j = i + 1;
            if (i + 1 < someText.Length && someText[i] != someText[j])
            {
                sb.Append(someText[i]);
            }
        }
        if (someText[someText.Length - 1] != someText[someText.Length - 2])
        {
            sb.Append(someText[someText.Length - 1]);
        }
        if (someText[someText.Length - 1] == someText[someText.Length - 2] && someText[someText.Length - 2] != someText[someText.Length - 3])
        {
            sb.Append(someText[someText.Length - 2]);
        }

        string lettersStr = sb.ToString();
        return lettersStr;
    }

    static void Main()
    {
        string letters = LettersCount();

        Console.WriteLine(letters);
    }
}

