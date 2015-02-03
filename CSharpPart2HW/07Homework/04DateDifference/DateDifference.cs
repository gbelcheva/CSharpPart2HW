using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _04DateDifference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            CultureInfo bgBG = new CultureInfo("bg-BG");
            Console.WriteLine("Input two dates dd.MM.yyyy: ");
            string inputDate = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(inputDate, "dd.MM.yyyy", bgBG);
            inputDate = Console.ReadLine();
            DateTime endDate = DateTime.ParseExact(inputDate, "dd.MM.yyyy", bgBG);
            TimeSpan timeDifference = endDate - startDate;
            Console.WriteLine("Days between: {0}", timeDifference.Days);
        }
    }
}
