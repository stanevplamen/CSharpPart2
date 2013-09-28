using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class XmlFileExtract
{
    static void Main()
    {
        // 1. extracting text from xml file
        string overallString = TextExtract();

        // 2. lining up the answer (on separate lines) and export to e file
        LoadResultFile(overallString);
    }

    static string RemoveBetween(string s, char begin, char end)
    {
        Regex regex = new Regex(string.Format("\\{0}.*?\\{1}", begin, end));
        string output = regex.Replace(s, string.Empty + "\r\n");
        return output;
    }

    static string TextExtract()
    {
        string textFile = @"..\..\TestFile.xml";
        StreamReader streamReader = new StreamReader(textFile);
        string fileContents = null;

        using (streamReader)
        {
            fileContents = streamReader.ReadToEnd();
        }
        string removeBrackets = RemoveBetween(fileContents, '<', '>');
        return removeBrackets;
    }

    static void LoadResultFile(string outputs)
    {
        string fileName = @"..\..\ResultText.txt";
        StreamWriter streamWriter = new StreamWriter(fileName);
        using (streamWriter)
        {
            streamWriter.Write(outputs);
        }

        StreamReader streamReader = new StreamReader(fileName);
        StringBuilder MyStringBuilder = new StringBuilder();
        using (streamReader)
        {
            int lineNumber = 1;
            string line = streamReader.ReadLine();
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
        StreamWriter streamWriter2 = new StreamWriter(fileName);
        using (streamWriter2)
        {
            streamWriter2.Write(overallString);
        }

        Console.WriteLine(overallString);
    }
}

