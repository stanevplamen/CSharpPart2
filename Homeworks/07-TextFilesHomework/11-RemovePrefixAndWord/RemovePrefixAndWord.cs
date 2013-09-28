using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

class RemovePrefixAndWord
{
    static void Main()
    {
        // 1. provide a text file
        LoadTextFile();

        // 2. read and replace the start -> finish
        ReplaceWord();
    }

    static void LoadTextFile()
    {
        Console.Write("Please select the number of \"words\" to generate: ");
        ulong rows = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Waiting a little due to the generation...");
        StringBuilder MyStringBuilder = new StringBuilder();

        for (ulong i = 1; i < rows; i++)
        {
            int custom = RandomNumber();
            switch (custom)
            {
                case 1:
                    MyStringBuilder.Append("testToBeRemoved ");
                    break;
                case 2:
                    MyStringBuilder.Append("notToBeRemovedtest ");
                    break;
                case 3:
                    MyStringBuilder.Append("other words ");
                    break;
                default:
                    break;
            }
        }

        string overallString = MyStringBuilder.ToString();
        string textFile = @"..\..\BigText.txt";
        StreamWriter streamWriter = new StreamWriter(textFile);

        using (streamWriter)
        {
            streamWriter.Write(overallString);
        }
        Console.WriteLine("The start is written!");
    }

    static int RandomNumber()
    {
        Random rnd = new Random();
        Thread.Sleep(2);
        int random = rnd.Next(1, 4);
        return random;
    }

    static void ReplaceWord()
    {
        string textFile = @"..\..\BigText.txt";
        StreamReader streamReader = new StreamReader(textFile);
        string bigString = streamReader.ReadToEnd();
        string pattern = @"\btest\w+";
        string replace = "";
        string overallString = Regex.Replace(bigString, pattern, replace);

        string outputFile = @"..\..\BigTextReplace.txt";
        StreamWriter streamWriter = new StreamWriter(outputFile, false, Encoding.UTF8);

        using (streamWriter)
        {
            streamWriter.Write(overallString);
        }
        Console.WriteLine("The finish is written!");
    }
}

