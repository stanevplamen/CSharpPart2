using System;
using System.IO;

class OddLinesPrint
{
    static void Main()
    {
        // creating the file
        string fileName = @"..\..\TextFileToRead.txt";
        StreamWriter streamWriter = new StreamWriter(fileName);
        int linesToMake = 77;
        using (streamWriter)
        {
            for (int i = 1; i <= linesToMake; i++)
            {
                streamWriter.WriteLine("This is line number {0}", i);
            }
        }

        // reading odd lines
        StreamReader oddReader = new StreamReader(fileName);
        using (oddReader)
        {
            int lineNumber = 1;
            string line = oddReader.ReadLine();
            while (line != null)
            {
                if ((lineNumber % 2) == 1)
                {
                    Console.WriteLine(line);
                }
                line = oddReader.ReadLine();
                lineNumber++;
            }
        }
    }
}

