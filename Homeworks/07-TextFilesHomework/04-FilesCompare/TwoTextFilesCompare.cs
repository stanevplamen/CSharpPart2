using System;
using System.IO;

class TwoTextFilesCompare
{
    #region Making of text files
    static int numberOfOutputs = 0;
    static void MakingOfTextFile(int numberOfLinesType1, int numberOfLinesType2)
    {
        numberOfOutputs++;
        string fileNameOne = @"..\..\TextTemp01-" + numberOfOutputs + ".txt";
        StreamWriter streamWriterOne = new StreamWriter(fileNameOne);
        using (streamWriterOne)
        {
            for (int i = 1; i <= numberOfLinesType1; i++)
            {
                streamWriterOne.WriteLine("Line type 1");
            }
        }

        string fileNameTwo = @"..\..\TextTemp02-" + numberOfOutputs + ".txt";
        StreamWriter streamWriterTwo = new StreamWriter(fileNameTwo);
        using (streamWriterTwo)
        {
            for (int i = 1; i <= numberOfLinesType2; i++)
            {
                streamWriterTwo.WriteLine("Line type 2");
            }
        }

        // concatenating output file
        string fileNameThree = @"..\..\TextFileToCompare" + numberOfOutputs + ".txt";
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
    }
    #endregion Making of text files


    static void Main()
    {
        // first file parameters
        int numberOfLinesType1 = 20;
        int numberOfLinesType2 = 20;

        MakingOfTextFile(numberOfLinesType1, numberOfLinesType2);

        // second file parameters
        numberOfLinesType1 = 5;
        numberOfLinesType2 = 35;

        MakingOfTextFile(numberOfLinesType1, numberOfLinesType2);

        // counting the equal lines
        string fileToCompareOne = @"..\..\TextFileToCompare1.txt";
        string fileToCompareTwo = @"..\..\TextFileToCompare2.txt";
        StreamReader streamReaderOne = new StreamReader(fileToCompareOne);
        StreamReader streamReaderTwo = new StreamReader(fileToCompareTwo);

        int counter = 0;
        using (streamReaderOne)
        using (streamReaderTwo)
        {
            string lineOne = streamReaderOne.ReadLine();
            string lineTwo = streamReaderOne.ReadLine();

            while (lineOne != null && lineTwo != null)
            {
                lineOne = streamReaderOne.ReadLine();
                lineTwo = streamReaderTwo.ReadLine();
                if (lineOne == lineTwo)
                {
                    counter++;
                    Console.WriteLine("The {0} equal line is {1}", counter, lineOne);
                }
            }
        }
        Console.WriteLine("\nTotal {0} equal lines, {1} different", counter, numberOfLinesType1 + numberOfLinesType2 - counter);
    }
}

