using System;
using System.Collections.Generic;
using System.Text;

class Splitter
{
    static void Main()
    {
        string expression = "43 68 9 23 318";

        List<string> splitedNumbs = SplitFunction(expression);
        Console.WriteLine("The given string is {0}", expression);
        Print(splitedNumbs);
    }

    private static List<string> SplitFunction(string expression)
    {
        bool signCurrent = true;
        List<string> numbs = new List<string>();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < expression.Length; i++)
        {
            signCurrent = true;
            if (expression[i] == ' ')
            {
                signCurrent = false;
            }
            else
            {
                sb.Append(expression[i]);
            }

            if (signCurrent == false)
            {
                string current = sb.ToString();
                numbs.Add(current);
                sb = new StringBuilder();
            }
        }

        if (signCurrent == true)
        {
            string current = sb.ToString();
            numbs.Add(current);
        }
        return numbs;
    }

    private static void Print(List<string> splitedNumbs)
    {
        Console.WriteLine("Splited Numbers are as follows: ");
        foreach (var numb in splitedNumbs)
        {
            Console.WriteLine(numb);
        }
    }
}

