using System;
using System.Text;

class TwentyCharsString
{
    static void CheckStringLength(string userInput)
    {
        if (userInput.Length > 20)
        {
            Console.WriteLine("The chars are more than 20");
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            return;
        }
    }

    static void Main()
    {
        Console.Write("Please enter a string (max 20 chars): ");
        string userInput = Console.ReadLine();
        CheckStringLength(userInput);

        string result = Convert.ToString(userInput.PadRight(20, '*'));
        Console.WriteLine(result);
    }
}