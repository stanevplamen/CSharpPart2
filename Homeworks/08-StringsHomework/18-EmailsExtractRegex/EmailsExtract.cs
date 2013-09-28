using System;
using System.Text.RegularExpressions;

class EmailsExtractRegex
{
    static void Main()
    {
        string someText = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
        string splitPattern = @"[;|,|\s|\|]+";
        string[] sents = Regex.Split(someText, splitPattern);

        string regex = @"^([a-zA-Z0-9_\-][a-zA-Z0-9_\-\.]{0,49})" + @"@(([a-zA-Z0-9][a-zA-Z0-9\-]{0,49}\.)+[a-zA-Z]{2,4})";
        Console.WriteLine("The extracted emails are:");
        foreach (var item in sents)
        {
            Match match = Regex.Match(item, regex);
            while (match.Success)
            {
                Console.WriteLine("{0}", match);
                match = match.NextMatch();
            }
        }

    }
}

