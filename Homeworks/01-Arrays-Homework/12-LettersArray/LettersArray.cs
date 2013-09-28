using System;
using System.Collections.Generic;

class LettersArray
{
    static void Main()
    {
        List<char> lettersList = new List<char>();
        for (int i = 65; i <= 90; i++)
        {
            char ch = Convert.ToChar(i);
            lettersList.Add(ch);
        }

        Console.Write("Please enter a word with symbols A-Z): ");
        string charsWord = Console.ReadLine().ToUpper();

        List<char> charListCharsWord = new List<char>();

        foreach (char words in charsWord)
        {
            charListCharsWord.Add(words);
        }

        List<int> indexArray = new List<int>();
        for (int i = 0; i < charListCharsWord.Count; i++)
        {
            for (int j = 0; j < lettersList.Count; j++)
            {
                if (charListCharsWord[i] == lettersList[j])
                {
                    // the index is j
                    // the checked member is i
                    indexArray.Add(j);
                }
            }
        }
        Console.Write("The relevant index values of the word are: ");
        foreach (int c in indexArray)
        {
            Console.Write("{0},", c);
        }
        Console.Write("\b;");
        Console.WriteLine();
    }
}
