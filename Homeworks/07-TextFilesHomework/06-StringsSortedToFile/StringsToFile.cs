using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class StringsToFile
{
    /// <summary>
    /// We are given a list of strings
    /// The string are written to a text file
    /// The text file is read again according to the task assigment
    /// After that the strings are sorted and written to the result file: StringListSorted.txt
    /// </summary>
    static void Main()
    {
        // 1. here is the following list of strings
        List<string> listNames = new List<string> { "Ivan", "Gosho", "Pesho", "Mitko", "Krasi", "Rosen", "Vladi", "Simo", "Andrey" };

        // 2. load the list to a txt file
        string fileToMake = @"..\..\StringList.txt";
        LoadToText(listNames, fileToMake);

        // 3. read the text file
        List<string> listNamesFromFile = ListFromFile();

        // 4. sort the list
        listNamesFromFile.Sort();

        // 5. export the sorted list to file
        string fileToResult = @"..\..\StringListSorted.txt";
        LoadToText(listNamesFromFile, fileToResult);
        Console.WriteLine("Result loaded");
    }

    static void LoadToText(List<string> listNames, string fileToMake)
    {
        StreamWriter streamWriter = new StreamWriter(fileToMake);

        using (streamWriter)
        {
            foreach (var strName in listNames)
            {
                streamWriter.WriteLine(strName);
            }
        }
        return;
    }

    static List<string> ListFromFile()
    {
        string fileToLoad = @"..\..\StringList.txt";
        StreamReader streamReaderOne = new StreamReader(fileToLoad);
        List<string> listNames = new List<string>();

        using (streamReaderOne)
        {
            string line = streamReaderOne.ReadLine();

            while (line != null)
            {
                listNames.Add(line);
                line = streamReaderOne.ReadLine();
            }
        }
        return listNames;
    }
}

