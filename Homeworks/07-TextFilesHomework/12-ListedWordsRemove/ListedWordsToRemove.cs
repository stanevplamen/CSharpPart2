using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

class ListedWordsToRemove
{
    /// <summary>
    /// Generating text file of words that should be deleted
    /// Using the same method generate longer file with more words
    /// Removing words and writing the result file with exception handling
    /// </summary>
    static void Main()
    {
        // 1. Generate the words to delete
        string wordsToDelete = @"..\..\WordsToDelete.txt";
        int lines = 50;
        CreateText(wordsToDelete, lines);

        // 2. Generate the words to delete from
        string wordsToDeleteFrom = @"..\..\WordsToDeleteFrom.txt";
        lines = 100;
        CreateText(wordsToDeleteFrom, lines);

        // 3. Removing the words given in file WordsToDelete.txt from WordsToDeleteFrom.txt
        RemoveWords(wordsToDelete, wordsToDeleteFrom);
    }

    static void CreateText(string fileName, int linesToMake)
    {
        StreamWriter streamWriter = new StreamWriter(fileName);
        using (streamWriter)
        {
            for (int i = 1; i <= linesToMake; i++)
            {
                streamWriter.WriteLine("Word{0}", i);
            }
        }
    }

    static void RemoveWords(string wordsToDelete, string wordsToDeleteFrom)
    {
        string readerToString = String.Empty;
        try
        {
            readerToString = String.Join(" ", File.ReadAllLines(wordsToDelete));
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine("Directory not found");
            throw new DirectoryNotFoundException(e.Message);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File not found");
            throw new FileNotFoundException(e.Message);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The path is null");
            throw new ArgumentNullException();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("The path is a zero-length string, contains only white space, or contains one or more invalid characters");
            throw new ArgumentException(e.Message);
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length");
            throw new PathTooLongException(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine("An I/O error occurred while opening the file");
            throw new IOException(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine("You do not have the required permission or path specified a directory");
            throw new UnauthorizedAccessException(e.Message);
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine("The path is in an invalid format");
            throw new NotSupportedException(e.Message);
        }
        string[] readWords = readerToString.Split(' ');

        string readDeleteFromString = String.Join(" ", File.ReadAllLines(wordsToDeleteFrom));
        string[] wordsDeleteFrom = readDeleteFromString.Split(' ');
        List<string> resultWords = new List<string>();

        foreach (var wordDeleteFrom in wordsDeleteFrom)
        {
            bool del = false;
            foreach (var delete in readWords)
            {
                if (wordDeleteFrom == delete)
                {
                    del = true;
                }
            }
            if (del == false)
            {
                resultWords.Add(wordDeleteFrom);
            }
            else
            {
                continue;
            }
        }

        string resultWordsStr = string.Empty;
        foreach (var word in resultWords)
        {
            resultWordsStr = resultWordsStr + word + " ";
        }

        string result = @"..\..\ResultWords.txt";
        StreamWriter streamWriter = new StreamWriter(result);
        try
        {
            using (streamWriter)
            {
                streamWriter.Write(resultWordsStr);
            }
            Console.WriteLine("The written finished!");
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine("Directory not found");
            throw new DirectoryNotFoundException(e.Message);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The path is null");
            throw new ArgumentNullException();
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("The path is a zero-length string, contains only white space, or contains one or more invalid characters");
            throw new ArgumentException(e.Message);
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length");
            throw new PathTooLongException(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine("An I/O error occurred while opening the file");
            throw new IOException(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine("You do not have the required permission or path specified a directory");
            throw new UnauthorizedAccessException(e.Message);
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine("The path is in an invalid format");
            throw new NotSupportedException(e.Message);
        }
    }
}