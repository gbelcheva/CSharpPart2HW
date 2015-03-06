using System;
using System.Linq;
using System.Text;
using System.Globalization;

namespace _01.Next_Date
{
    class NextDate
    {
        static void Main(string[] args)
        {
            int[] date = new int[3];
            for (int i = 0; i < 3; i++)
            {
                date[i] = int.Parse(Console.ReadLine());
            }
            DateTime fullDate = new DateTime(date[2], date[1], date[0]);
            Console.WriteLine(fullDate.AddDays(1).ToString("d.M.yyyy", CultureInfo.InvariantCulture));
        }
    }
}
