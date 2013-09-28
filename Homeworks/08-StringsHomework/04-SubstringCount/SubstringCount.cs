using System;
using System.Text;

class SubstringCount
{
    static int SubstringCounter(string textTemp, string targetTemp)
    {
        string text = textTemp.ToUpper();
        string target = targetTemp.ToUpper();

        int counter = -1;
        int index = -1;
        do
        {
            index = text.IndexOf(target, index + 1);
            counter++;

        } while (index != -1);

        return counter;
    }

    static void Main()
    {
        string someText = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string target = "in";
        int countTarget = SubstringCounter(someText, target);
        Console.WriteLine(@"The substring ""{0}"" is repeating {1} times", target, countTarget);
    }
}

