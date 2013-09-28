using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class RemoveBetweenTags
{
    static void Main()
    {
        TextExtract();
    }

    /// <summary>
    /// Copy the string text to html file
    /// Read the html file and extract the text between tags
    /// Write the output to another txt file and console
    /// </summary>
    static void TextExtract()
    {
        string fileContents = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        
        string fileName = @"..\..\InputText.html";
        StreamWriter streamWriter = new StreamWriter(fileName);
        using (streamWriter)
        {
            streamWriter.Write(fileContents);
        }

        StreamReader streamReader = new StreamReader(fileName);
        StringBuilder MyStringBuilder = new StringBuilder();
        using (streamReader)
        {
            int lineNumber = 1;
            string line = streamReader.ReadLine();
            line = RemoveBetween(line, '<', '>');
            while (line != null)
            {
                if ((line) != string.Empty)
                {
                    MyStringBuilder.Append(line);
                    MyStringBuilder.AppendLine();
                }
                line = streamReader.ReadLine();
                lineNumber++;
            }
        }

        string overallString = MyStringBuilder.ToString();
        string fileOutput = @"..\..\OutputText.txt";
        streamWriter = new StreamWriter(fileOutput);
        using (streamWriter)
        {
            streamWriter.Write(overallString);
        }

        Console.WriteLine(overallString);
    }

    static string RemoveBetween(string s, char begin, char end)
    {
        Regex regex = new Regex(string.Format("\\{0}.*?\\{1}", begin, end));
        string output = regex.Replace(s, string.Empty + " ");
        return output;
    }
}
