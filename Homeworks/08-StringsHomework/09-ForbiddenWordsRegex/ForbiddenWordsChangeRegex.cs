using System;
using System.Text;
using System.Text.RegularExpressions;

class ForbiddenWordsChangeRegex
{
    static string ForbiddenChange(string text, string[] forbidden)
    {
        string[] replace = new string[forbidden.Length];
        string ss = text;

        for (int i = 0; i < forbidden.Length; i++)
        {
            StringBuilder stars = new StringBuilder();
            for (int j = 0; j < forbidden[i].Length; j++)
            {
                stars.Append('*');
            }
            replace[i] = stars.ToString();

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(@"\b{0}\b", forbidden[i]);
            string pattern = sb.ToString();
            Regex r = new Regex(pattern);

            ss = r.Replace(ss, replace[i]);
        }
        return ss;
    }

    static void Main()
    {
        // This is given text and forbidden words
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbidden = { "Microsoft", "PHP", "CLR" };

        // direct changing the words via pattern
        string result = ForbiddenChange(text, forbidden);
        Console.WriteLine(result);
    }
}
