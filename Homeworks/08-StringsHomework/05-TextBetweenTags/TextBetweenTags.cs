using System;
using System.Text;

class TextBetweenTags
{
    static string TextConvertor(string text, string start, string end)
    {
        string[] wordsArray = text.Split(' ', '>', '<');
        StringBuilder sb = new StringBuilder();
        bool capitalize = false;
        for (int i = 0; i < wordsArray.Length; i++)
        {
            if (wordsArray[i] == start)
            {
                capitalize = true;
                continue;
            }
            if (wordsArray[i] == end)
            {
                capitalize = false;
                continue;
            }

            if (capitalize == false)
            {
                if (wordsArray[i] == "." || wordsArray[i] == ",")
                {
                    string temp = "\b" + wordsArray[i] + " ";
                    sb.Append(temp);
                    continue;
                }
                if (wordsArray[i] == "")
                {
                    string temp = wordsArray[i];
                    sb.Append(temp);
                }
                else
                {
                    string temp = wordsArray[i] + " ";
                    sb.Append(temp);
                }

            }
            else if (capitalize == true)
            {
                if (wordsArray[i] == "")
                {
                    string temp = (wordsArray[i]).ToUpper();
                    sb.Append(temp);
                }
                else
                {
                    string temp = (wordsArray[i] + " ").ToUpper();
                    sb.Append(temp);
                }
            }
        }
        sb.Append("\b");
        string result = sb.ToString();
        return result;
    }

    static void Main()
    {
        string beforeReverse = "We are, living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string start = "upcase";
        string end = "/upcase";
        string result = TextConvertor(beforeReverse, start, end);
        Console.WriteLine(result);
    }
}

