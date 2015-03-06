using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

//Problem 19. Dates from text in Canada

//    Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//    Display them in the standard date format for Canada.
//"kldsnglksndg 05.05.1987 dg fdg48684 2.6565.54 fgdfg31.05.1987 fdgfs 65/65/1987 65.54.5089"

namespace _19DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string text = Console.ReadLine();
            List<DateTime> dates = new List<DateTime>();
            DateTime tmpDate;
            for (int i = 0; i < text.Length - "DD.MM.YYYY".Length; i++)
            {
                if (DateTime.TryParseExact(text.Substring(i, "DD.MM.YYYY".Length), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out tmpDate))
                {
                    dates.Add(tmpDate);
                }
            }
            Console.WriteLine("\nExtracted dates in Canadian format:\n");
            foreach (DateTime date in dates)
            {
                Console.WriteLine(date.ToString("d", new CultureInfo("en-CA", false)));
            }
        }
    }
}
