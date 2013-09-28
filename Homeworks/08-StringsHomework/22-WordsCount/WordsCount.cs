using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class WordsCountStandard
{
    static Dictionary<string, int> WordsCount(string[] words)
    {
        Dictionary<string, int> wordsCountDict = new Dictionary<string, int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (wordsCountDict.ContainsKey(words[i]))
            {
                wordsCountDict[words[i]]++;
            }
            else
            {
                wordsCountDict.Add(words[i], 1);
            }
        }
        return wordsCountDict;
    }

    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!,C# is not C++,C# is not C++.....";
        string[] words = sentence.Split(new char[] { ',', ' ', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> dotNetWords = WordsCount(words);

        foreach (KeyValuePair<string, int> kvp in dotNetWords)
        {
            string answer = string.Format("{0} - {1}", kvp.Key, kvp.Value);
            Console.WriteLine(answer);
        }
    }
}
