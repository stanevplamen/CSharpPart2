using System;
using System.Text;
using System.Text.RegularExpressions;

class BracketsCheckerSearch
{
    static bool BracketsChecker(string expression)
    {
        bool sign = true;
        int counter = 0;
        char open = '(';
        char close = ')';
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == open)
            {
                counter++;
                continue;
            }
            else if (expression[i] == close)
            {
                if (counter == 0)
                {
                    sign = false;
                    break;
                }
                else
                {
                    counter--;
                }
            }
        }
        return sign;
    }

    static void Main()
    {
        // solution which allows nesting of brackers (works for () brackers)
        string expressionSearch = "()";
        bool correctBrackets = BracketsChecker(expressionSearch);
        Console.WriteLine("The bracketrs of {0} are correnct? {1}", expressionSearch, correctBrackets);

        // solution with regex which can not be used for nested brackets (works for [] brackers)
        string expressionRegex = "[a+b]/[5-5]";
        bool correctBracketsRegex = BracketsCheckerRegex.BracketsChecker(expressionRegex);
        Console.WriteLine("The bracketrs of {0} are correnct? {1}", expressionRegex, correctBracketsRegex);
    }
}

public class BracketsCheckerRegex
{
    public static bool BracketsChecker(string expression)
    {
        Regex expressionRegex = new Regex(@"^([^[\]]*\[[^[\]]*\]){0,3}[^[\]]*$");
        bool sign = expressionRegex.IsMatch(expression);
        return sign;
    }
}

/* Обяснение за regex формата:
    (...){0,3} работи за до три повторения на следните под-изрази:
        [^[\]]* за всеки символ който не е скоба
        \[ за всяка отваряща скоба [ 
        [^[\]]* за всеки символ който не е скоба
        \] за всяка затваряща скоба ]
    отново, [^[\]]* за всеки символ който не е скоба след скобите
*/