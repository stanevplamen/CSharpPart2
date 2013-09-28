using System;
using System.IO;

class TextFilesConcatenation
{
    static void Main()
    {
        // creating the files
        string fileNameOne = @"..\..\TextFileToRead01.txt";
        StreamWriter streamWriterOne = new StreamWriter(fileNameOne);
        using (streamWriterOne)
        {
            for (int i = 1; i <= 50; i++)
            {
                streamWriterOne.WriteLine("This is text file 1");
            }
        }

        string fileNameTwo = @"..\..\TextFileToRead02.txt";
        StreamWriter streamWriterTwo = new StreamWriter(fileNameTwo);
        using (streamWriterTwo)
        {
            for (int i = 1; i <= 60; i++)
            {
                streamWriterTwo.WriteLine("This is text file 2");
            }
        }

        // concatenating the files
        string fileNameThree = @"..\..\TextFileToSum.txt";
        StreamWriter streamWriterThree = new StreamWriter(fileNameThree, false);
        using (streamWriterThree)
        {
            StreamReader streamReaderOne = new StreamReader(fileNameOne);
            StreamReader streamReaderTwo = new StreamReader(fileNameTwo);
            string fileOneContents = streamReaderOne.ReadToEnd();
            string fileTwoContents = streamReaderTwo.ReadToEnd();

            streamWriterThree.WriteLine(fileOneContents);
            streamWriterThree.WriteLine(fileTwoContents);
        }
        Console.WriteLine("The files have been written");
    }
}

