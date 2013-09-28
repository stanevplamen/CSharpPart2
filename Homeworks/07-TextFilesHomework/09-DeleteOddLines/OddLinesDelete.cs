using System;
using System.IO;
using System.Text;

class OddLinesDelete
{
    static void Main()
    {
        // 1. provide a text file
        LoadTextFile();

        // 2. reading even lines
        string overallString = OddLinesDeleter();

        // 3. writing the even lines
        LoadResultFile(overallString);
    }

    static void LoadTextFile()
    {
        string fileName = @"..\..\TextFile.txt";
        StreamWriter streamWriter = new StreamWriter(fileName);
        int linesToMake = 77;
        using (streamWriter)
        {
            for (int i = 1; i <= linesToMake; i++)
            {
                streamWriter.WriteLine("This is line number {0}", i);
            }
        }
        Console.WriteLine("The start file is written! (you can check if because it will be deleted)");
        Console.WriteLine("Press a key when ready");
        Console.ReadKey();
    }

    static string OddLinesDeleter()
    {
        string textFile = @"..\..\TextFile.txt";
        StreamReader streamReader = new StreamReader(textFile);
        StringBuilder MyStringBuilder = new StringBuilder();

        using (streamReader)
        {
            int lineNumber = 1;
            string line = streamReader.ReadLine();
            while (line != null)
            {
                if ((lineNumber % 2) == 0)
                {
                    MyStringBuilder.Append(line);
                    MyStringBuilder.AppendLine();
                }
                line = streamReader.ReadLine();
                lineNumber++;
            }
        }
        string overallString = MyStringBuilder.ToString();
        return overallString;
    }

    static void LoadResultFile(string evenLines)
    {
        string fileName = @"..\..\TextFile.txt";
        StreamWriter streamWriter = new StreamWriter(fileName);

        using (streamWriter)
        {
            streamWriter.Write(evenLines);
        }
        Console.WriteLine("The finish file is written!");
    }
}

