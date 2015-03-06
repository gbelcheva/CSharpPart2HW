using System;
using System.Collections.Generic;

//Problem 5. Workdays

//    Write a method that calculates the number of workdays between today and given date, passed as parameter.
//    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.


namespace _05Workdays
{
    class Workdays
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Today;
            Console.WriteLine("Input end date dd/MM/yy:");
            DateTime end = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yy", System.Globalization.CultureInfo.InvariantCulture);
            double workDays = 1 + ((end - start).TotalDays * 5 - (start.DayOfWeek - end.DayOfWeek) * 2) / 7;
            if ((int)end.DayOfWeek == 6)
            {
                workDays--;
            }
            if ((int)start.DayOfWeek == 0)
            {
                workDays--;
            }
            //Console.WriteLine("Input list of holidays dd/MM/yy:");
            //string input = "";
            //List<DateTime> holidays = new List<DateTime>();
            //while (input != "END")
            //{
            //    input = Console.ReadLine();
            //    holidays.Add(DateTime.ParseExact(input, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));
            //}
            string[] holidays = {"03/03/15", 
                                 "10/04/15", 
                                 "13/04/15", 
                                 "01/05/15", 
                                 "06/05/15", 
                                 "06/09/15", 
                                 "22/09/15", 
                                 "24/12/15", 
                                 "25/03/15"
                                 };

            for (int i = 0; i < holidays.Length; i++)
            {
                DateTime curHoliday = DateTime.ParseExact(holidays[i], "dd/MM/yy", System.Globalization.CultureInfo.InvariantCulture);
                if (start <= curHoliday && curHoliday <= end)
                {
                    workDays--;
                }
            }
            Console.WriteLine("Total working days: {0}", workDays);
        }
    }
}
