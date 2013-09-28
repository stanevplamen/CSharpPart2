using System;

class ReplaceHtml
{
    static void Main()
    {
        string textHtml = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string replacedOne = textHtml.Replace("\">", "]");
        replacedOne = replacedOne.Replace("\"", string.Empty);
        replacedOne = replacedOne.Replace("<a href", "[URL");
        replacedOne = replacedOne.Replace("</a>", "[/URL]");

        Console.WriteLine(replacedOne);
    }
}

