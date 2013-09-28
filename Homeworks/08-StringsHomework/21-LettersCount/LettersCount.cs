using System;
using System.Collections.Generic;

class LettersCountDict
{
    static string someText = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.".ToLower();

    static Dictionary<char, int> LettersCount()
    {
        Dictionary<char, int> letters = new Dictionary<char, int>();

        for (int i = 'a'; i <= 'z'; i++)
        {
            letters.Add((char)i, 0);
        }

        foreach (char c in someText)
        {
            if (letters.ContainsKey(c))
            {
                letters[c]++;
            }
        }
        return letters;
    }

    static void Main()
    {
        Dictionary<char, int> dotNetWords = LettersCount();

        foreach (KeyValuePair<char, int> kvp in dotNetWords)
        {
            if ((kvp.Value != 0) == true)
            {
                string answer = string.Format("{0} - {1}", kvp.Key, kvp.Value);
                Console.WriteLine(answer);
            }
        }
    }
}

