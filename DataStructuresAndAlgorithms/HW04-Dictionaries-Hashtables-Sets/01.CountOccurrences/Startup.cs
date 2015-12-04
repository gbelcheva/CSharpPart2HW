namespace _01.CountOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            //3, 4, 4, -2.5, 3, 3, 4, 3, -2.5
            var input = ReadInput();
            var occurrences = FindOccurrences(input);

            foreach (var occurrence in occurrences)
            {
                Console.WriteLine("{0} -> {1} time(s)", occurrence.Key, occurrence.Value);
            }
        }

        private static IDictionary<double, int> FindOccurrences(IEnumerable<double> numbers)
        {
            var occurrences = new Dictionary<double, int>();

            foreach (var item in numbers)
            {
                if (!occurrences.ContainsKey(item))
                {
                    occurrences[item] = 0;
                }

                occurrences[item]++;
            }

            return occurrences;
        }

        static IEnumerable<double> ReadInput()
        {
            var input = Console.ReadLine();

            var numbers = input
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToList();

            return numbers;
        }
    }
}
