using System;

class Year
{
    private int year;

    public int LeapYear
    {
        get
        {
            return this.year;
        }
        set
        {
            this.year = value;
        }
    }

    public Year()
    {
        this.year = 2010;
    }

    static bool IsLeap(int year)
    {
        bool four = year % 4 == 0;
        bool hundred = year % 100 == 0;
        bool fourHundred = year % 400 == 0;

        bool first = four ^ hundred;
        bool final = first | fourHundred;
        return final;
    }

    static void Main(string[] args)
    {
        Year myYear = new Year();
        myYear.LeapYear = 2000;

        bool check = IsLeap(myYear.LeapYear);
        Console.WriteLine("{0} id leap? - {1}", myYear.LeapYear, check);
    }
}

