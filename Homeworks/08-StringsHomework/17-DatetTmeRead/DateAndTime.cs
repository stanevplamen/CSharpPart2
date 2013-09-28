using System;
using System.Globalization;
using System.Threading;

class DateAndTimeRead
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        string date = "11.03.2012";
        string time = "19:10:00";

        DateTime dateOne = DateTime.ParseExact(date + time, "d.MM.yyyy" + "HH:mm:ss", new CultureInfo("bg-BG"));
        dateOne = dateOne.AddHours(6);
        dateOne = dateOne.AddMinutes(30);

        var dayOfWeek = dateOne.DayOfWeek;
        Console.Write("The date and time after 6:30h will be: {0}, ", dateOne);
        string s = dateOne.ToString("dddd, (dd MMMM yyyy)");
        Console.WriteLine(s);
    }
}

