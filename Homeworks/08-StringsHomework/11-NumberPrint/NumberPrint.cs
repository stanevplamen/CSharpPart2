using System;
using System.Globalization;
using System.Threading;

class NumberPrint
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        Console.Write("Please enter a number: ");
        decimal userNumber = decimal.Parse(Console.ReadLine());

        string formatDecimal = String.Format("{0,15}| type decimal", userNumber);
        string formatHex = String.Format("{0,15}| hex presentation of the int part", Convert.ToString((int)userNumber, 16).ToUpper());
        string formatPercentage = String.Format("{0,15:P}| as percentage", userNumber);
        string formatScient = String.Format("{0,15:E7}| as scientific notation", userNumber);

        string finalStr = String.Format("{0}\n{1}\n{2}\n{3}", formatDecimal, formatHex, formatPercentage, formatScient);
        Console.WriteLine(finalStr);
    }
}

