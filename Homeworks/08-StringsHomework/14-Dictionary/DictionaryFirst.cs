using System;
using System.Collections.Generic;

class DictionaryFirst
{
    static Dictionary<string, string> DictionaryMethod(string[] dictionary)
    {
        Dictionary<string, string> dotNetWords = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        for (int i = 0; i < dictionary.Length; i++)
        {
            string[] dictsArray = dictionary[i].Split('-', '–');
            dotNetWords.Add((dictsArray[0].Trim()), dictsArray[1]);
        }
        return dotNetWords;
    }

    static void Testing(Dictionary<string, string> dotNetWords)
    {
        Console.Write("Please enter a word for search: ");
        string userInput = Console.ReadLine().Trim();


        if (dotNetWords.ContainsKey(userInput))
        {
            string answer = string.Format("{0} - {1}", userInput, dotNetWords[userInput]);
            Console.WriteLine(answer);
            return;
        }
        else
        {
            Console.WriteLine("The entered word can not be found");
            return;
        }
    }

    static void Main()
    {
        string[] dictionary =
        { 
            ".NET - platform for applications from Microsoft" ,
            "CLR - managed execution environment for .NET" ,
            "namespace – hierarchical organization of classes" ,                              
        };
        Dictionary<string, string> dotNetWords = DictionaryMethod(dictionary);

        Testing(dotNetWords);
    }
}

