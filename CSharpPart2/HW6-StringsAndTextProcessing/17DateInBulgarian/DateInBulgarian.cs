using System;
using System.Globalization;

//Problem 17. Date in Bulgarian

//    Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
//27.02.2006 12:05:37


namespace _17DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date:");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddHours(6).AddMinutes(30);
            Console.WriteLine(date.ToString("d.MM.yyyy hh:mm:ss dddd", new CultureInfo("bg-BG", false)));
        }
    }
}
