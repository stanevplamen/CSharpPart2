using System;
using System.Globalization;

class DateRead
{
    static void Main()
    {
        Console.Write("Please enter the first date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Please enter the second date: ");
        string secondDate = Console.ReadLine();

        DateTime dateOne = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime dateTwo = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
        var dateThree = (dateTwo - dateOne);

        string days = string.Format("{0:dd}", dateThree);
        Console.WriteLine("Distance : {0} days", days);
    }
}

