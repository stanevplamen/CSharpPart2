using System;
using System.Collections.Generic;
using System.Text;

class WordsReverse
{
    static List<int> SignCount(string text, char target)
    {
        List<int> positions = new List<int>();
        int count = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ')
            {
                count++;
            }
            if (text[i] == target)
            {
                positions.Add(count);
            }
        }
        return positions;
    }

    static string WordsChange(string text, List<int> positionsExc, List<int> positionsComas, List<int> positionsDots)
    {
        string[] splitters = new string[] { ". ", ".\t", ".", "! ", "!\t", "!", }; //
        string[] sentsArray = text.Split(splitters, StringSplitOptions.None); // the other option
        StringBuilder sb = new StringBuilder();
        int counter = 0;
        foreach (var sentence in sentsArray)
        {
            string[] wordsArray = sentence.Split(',', '-', ' ', '.', '!');
            for (int i = wordsArray.Length - 1; i >= 0; i--)
            {
                counter++;
                sb.Append(wordsArray[i]);
                sb.Append(' ');
                for (int ex = 0; ex < positionsExc.Count; ex++)
                {
                    if (counter == positionsExc[ex] + 2)
                    {
                        sb.Append('!');
                    }
                }

                for (int com = 0; com < positionsComas.Count; com++)
                {
                    if (counter == positionsComas[com] + 1)
                    {
                        sb.Append(',');
                        sb.Append(' ');
                    }
                }

                for (int dot = 0; dot < positionsDots.Count; dot++)
                {
                    if (counter == positionsDots[dot] + 2)
                    {
                        sb.Append('.');
                    }
                }
            }
        }
        string result = sb.ToString();
        return result;
    }

    static string Format(string text)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            if (i + 1 < text.Length && text[i] == ' ' && (text[i + 1] == '.' || text[i + 1] == ',' || text[i + 1] == '!'))
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
        string text = "C# is not C++, not PHP and not Delphi!";

        // Here we are copying the positions of the dots '.'
        char targetDot = '.';
        List<int> positionsDots = SignCount(text, targetDot);
        char targetComa = ',';
        List<int> positionsComas = SignCount(text, targetComa);
        char targetExcl = '!';
        List<int> positionsExc = SignCount(text, targetExcl);

        // Here we are changing the words and putting the signs
        string changedText = WordsChange(text, positionsExc, positionsComas, positionsDots);

        // Here we are formating the result
        string format = Format(changedText);

        // Printing the result on the console
        Console.WriteLine(text);
        Console.WriteLine(format);
    }
}

