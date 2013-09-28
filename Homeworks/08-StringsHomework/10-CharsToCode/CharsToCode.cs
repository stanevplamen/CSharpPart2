using System;

class CharsToCode
{
    static string SequenceConvertor(string text)
    {
        string formatString = string.Empty;
        foreach (char c in text)
        {
            short value = (short)(c);
            formatString = formatString + String.Format("\\u{0:x4}", value);
        }

        return formatString;
    }

    static void Main()
    {
        string input = "Hi!";
        string result = SequenceConvertor(input);
        Console.WriteLine(result);
    }
}

