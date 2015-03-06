using System;

namespace _10BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            DateTime inputTime;
            while (! DateTime.TryParse(Console.ReadLine(), out inputTime))
            {
                Console.WriteLine("invalid time. Try again:");
            }
            DateTime startTime = DateTime.Parse("01:00 PM");
            DateTime endTime = DateTime.Parse("03:00 AM");
            endTime = endTime.AddDays(1);
            if (inputTime >= startTime && inputTime <= endTime) Console.WriteLine("beer time");
            else Console.WriteLine("non-beer time");
        }
    }
}
