using System;
using System.Globalization;
using System.Threading;

class CurrentDay
{
    static void Main()
    {
        DateTime today = new DateTime();
        today = DateTime.Now;
        var day = DateTime.Now.DayOfWeek.ToString();
        int dayNumber = today.Day;
        int month = today.Month;
        int year = today.Year;

        Console.WriteLine("EN/US culture");

        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        Console.WriteLine("The current day is {0}", day);
        Console.WriteLine("The current month is {0}", today.ToString("MMM"));
        Console.WriteLine("The current year is {0}", year);

        Console.WriteLine();
        Console.WriteLine("BG culture");

        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
        Console.WriteLine("Денят е {0:D}", dayNumber);
        Console.WriteLine("Месецът е {0}", today.ToString("MMM"));
        Console.WriteLine("Годината е {0}", year);
    }
}

