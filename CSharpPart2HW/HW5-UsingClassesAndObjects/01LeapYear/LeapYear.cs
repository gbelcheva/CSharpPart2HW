using System;

//Problem 1. Leap year

//    Write a program that reads a year from the console and checks whether it is a leap one.
//    Use System.DateTime.


namespace _01LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input year yyyy:");
            DateTime inputYear = DateTime.ParseExact(Console.ReadLine(), "yyyy", System.Globalization.CultureInfo.InvariantCulture);
            if (DateTime.IsLeapYear(inputYear.Year))
            {
                Console.WriteLine("Leap year.");
            }
            else
            {
                Console.WriteLine("Not leap year.");
            }
        }
    }
}
