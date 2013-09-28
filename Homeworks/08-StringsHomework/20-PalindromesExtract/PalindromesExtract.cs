using System;

class PalindromesExtract
{
    static string someText = "abba, exe, some words which are not palindromes, lamal.";

    static void Main()
    {
        string[] dividerBySpace = someText.Split(new char[] { ' ', ',', '-', ':', '\n', '.' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in dividerBySpace)
        {
            int length = word.Length / 2;
            bool sign = true;

            for (int i = 0; i < length; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    sign = false;
                    break;
                }
            }
            if (sign == true)
            {
                Console.WriteLine(word);
            }
        }
    }
}

