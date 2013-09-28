using System;
using System.Collections.Generic;

class WorkDays
{
    static void Main(string[] args)
    {
        int day = 3;
        int month = 10;
        int year = 2014;
        var holidays = new List<DateTime>();

        for (int i = 2013; i <= year; i++)
        {
            holidays = new List<DateTime>()
                            {
                                new DateTime(i, 1, 1),
                                new DateTime(i, 3, 3),
                                new DateTime(i, 3, 3),
                                new DateTime(i, 5, 3),
                                new DateTime(i, 5, 4),
                                new DateTime(i, 5, 5),
                                new DateTime(i, 5, 6),
                                new DateTime(i, 5, 24),
                                new DateTime(i, 9, 22),
                                new DateTime(i, 11, 1),
                                new DateTime(i, 12, 24),
                                new DateTime(i, 12, 25),
                                new DateTime(i, 12, 26),
                                new DateTime(i, 12, 30),
                                new DateTime(i, 12, 31),
                            };

        }

        DateTime future = new DateTime(year, month, day);
        var futureDays = CalculateFutureDate(DateTime.Today, future, holidays);

        Console.WriteLine("The working days from {0:d.MM.yyyy} and {1:d.MM.yyyy} are {2}", DateTime.Today, future, futureDays);
    }

    static int CalculateFutureDate(DateTime start, DateTime end, ICollection<DateTime> holidays)
    {
        var allDays = end.Subtract(start).TotalDays;

        int workDays = 0;
        for (int i = 1; i <= allDays; i++)
        {
            DateTime current = start.AddDays(i);
            int startDay = current.Day;
            if (current.DayOfWeek == DayOfWeek.Saturday || current.DayOfWeek == DayOfWeek.Sunday || (holidays != null && holidays.Contains(current)))
            {
                continue;
            }
            else
            {
                workDays++;
            }
        }

        return workDays;
    }
}
