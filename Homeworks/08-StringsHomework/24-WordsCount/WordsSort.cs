using System;

class WordsSort
{
    static void Main()
    {
        string sentence = "C# is not C++ not PHP and not Delphi!...";
        string[] words = sentence.Split(new char[] { ' ','.','!' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}

