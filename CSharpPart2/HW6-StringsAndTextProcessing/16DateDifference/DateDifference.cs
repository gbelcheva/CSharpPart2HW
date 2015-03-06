using System;

//Problem 16. Date difference

//    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days


namespace _16DateDifference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first date: ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Enter second date: ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            double span = Math.Abs((firstDate - secondDate).TotalDays);
            Console.WriteLine("Time span: {0} days", span);
        }
    }
}
