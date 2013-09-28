using System;
using System.Collections.Generic;
using System.Text;

class ForbiddenWordsChange
{
    static List<int> CopySymbols(string text)
    {
        string target = ".";
        List<int> positions = new List<int>();
        int index = -1;

        while (true)
        {
            index = text.IndexOf(target, index + 1);
            if (index == -1)
            {
                break;
            }
            positions.Add(index);
        }
        return positions;
    }

    static string ForbiddenChange(string text, string[] forbidden)
    {
        string[] splitters = new string[] { ". ", ".\t", "." + Environment.NewLine };
        string[] sentsArray = text.Split(splitters, StringSplitOptions.None);
        StringBuilder sb = new StringBuilder();
        foreach (var sentence in sentsArray)
        {
            string[] wordsArray = sentence.Split(',', '-', ' ', '.');
            foreach (var word in wordsArray)
            {
                bool sign = false;
                foreach (var forb in forbidden)
                {
                    if (word == forb)
                    {
                        for (int i = 0; i < word.Length; i++)
                        {
                            sb.Append('*');
                        }
                        sb.Append(' ');
                        sign = true;
                        break;
                    }
                }
                if (sign == false)
                {
                    sb.Append(word);
                    sb.Append(' ');
                }
            }
        }
        string result = sb.ToString();
        return result;
    }

    static string BuildString(List<int> positions, string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < positions.Count; j++)
            {
                if (i == positions[j])
                {
                    sb.Append('.');
                }
            }

            sb.Append(text[i]);
        }
        string result = sb.ToString();
        return result;
    }

    static string Format(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            if (i + 1 < text.Length && text[i + 1] == '.' && text[i] == ' ')
            {
                continue;
            }

            sb.Append(text[i]);
        }
        string result = sb.ToString();
        return result;

    }

    static void Main()
    {
        // This is given text and forbidden words
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbidden = { "Microsoft", "PHP", "CLR" };

        // Here we are copying the positions of the dots '.'
        List<int> positions = CopySymbols(text);

        // Here we are changing the forbidden words
        string changedText = ForbiddenChange(text, forbidden);

        // Here we are putting the dots in the sentence
        string result = BuildString(positions, changedText);

        // Here we are formating the result
        string format = Format(result);

        // Printing the result on the console
        Console.WriteLine(format);
    }
}

