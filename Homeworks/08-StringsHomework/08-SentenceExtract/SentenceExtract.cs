using System;
using System.Text;

class SentenceExtract
{
    static void SubstringCounter(string text, string target)
    {
        string[] splitters = new string[] { ". ", ".\t", "." + Environment.NewLine }; //
        string[] sentsArray = text.Split(splitters, StringSplitOptions.None); // the other option
        foreach (var sentence in sentsArray)
        {
            string[] wordsArray = sentence.Split(',', '-', ' ');
            bool sign = false;
            foreach (var word in wordsArray)
            {
                if (word == target)
                {
                    sign = true;
                    continue;
                }
            }
            if (sign == true)
            {
                Console.WriteLine(sentence);
            }
        }
    }

    static void Main()
    {
        string someText = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string target = "in";
        SubstringCounter(someText, target);
    }
}

