using System;
using System.IO;
using System.Text;

class WordReplacing
{
    /// <summary>
    /// The user enters a number of rows for generation of the text file (80000 for ~100MB)
    /// The file has been read and written again with the changed words
    /// </summary>
    static void Main()
    {
        // 1. provide a text file
        LoadTextFile();

        // 2. read and replace the start -> finish
        ReplaceWord();
    }

    static void LoadTextFile()
    {
        Console.Write("Please select the \"number of rows\":(80000 for ~100MB): ");
        ulong rows = ulong.Parse(Console.ReadLine());
        StringBuilder MyStringBuilder = new StringBuilder();

        for (ulong i = 1; i < rows; i++)
        {
            int custom = RandomNumber();
            switch (custom)
            {
                case 1:
                    MyStringBuilder.Append("start");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                    MyStringBuilder.Append('a', 10000);
                    break;
                case 6:
                case 7:
                case 8:
                    MyStringBuilder.Append('b', 10000);
                    break;
                case 9:
                case 10:
                    MyStringBuilder.AppendLine();
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
        int random = rnd.Next(1, 11);
        return random;
    }

    static void ReplaceWord()
    {
        string textFile = @"..\..\BigText.txt";
        StreamReader streamReader = new StreamReader(textFile, Encoding.GetEncoding("windows-1251"));
        string bigString = streamReader.ReadToEnd();
        StringBuilder sb = new StringBuilder(bigString);
        sb.Replace("start", "finish");

        string overallString = sb.ToString();
        string outputFile = @"..\..\BigTextReplace.txt";
        StreamWriter streamWriter = new StreamWriter(outputFile, false, Encoding.UTF8);

        using (streamWriter)
        {
            streamWriter.Write(overallString);
        }
        Console.WriteLine("The finish is written!");
    }
}

