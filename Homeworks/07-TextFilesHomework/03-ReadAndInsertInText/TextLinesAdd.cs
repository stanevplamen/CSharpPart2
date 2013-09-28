using System;
using System.IO;
using System.Threading;

class AddTextLines
{
    static void Main()
    {
        // creating the file to read from
        string fileNameOne = @"..\..\TextFileToRead01.txt";
        StreamWriter streamWriterOne = new StreamWriter(fileNameOne);
        using (streamWriterOne)
        {
            for (int i = 1; i <= 77; i++)
            {
                streamWriterOne.WriteLine("To check: This is line number {0}", i);
            }
        }

        // creating the result file
        string fileNameSum = @"..\..\TextFileResult.txt";
        StreamWriter streamWriter = new StreamWriter(fileNameSum, false);
        StreamReader streamReaderOne = new StreamReader(fileNameOne);
        using (streamReaderOne)
        using (streamWriter)
        {         
            string line = streamReaderOne.ReadLine();
            int lineNumber = 1;
            while (line != null)
            {
                streamWriter.WriteLine("Line " + lineNumber + " " + line);
                line = streamReaderOne.ReadLine();
                lineNumber++;
            }
        }
        Console.WriteLine("The files have been written");
    }
}

