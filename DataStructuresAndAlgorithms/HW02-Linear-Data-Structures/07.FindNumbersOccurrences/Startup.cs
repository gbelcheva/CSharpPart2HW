//Write a program that finds in given array of integers(all belonging to the range[0..1000]) how many times each of them occurs.

//  Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
//        2 → 2 times
//        3 → 4 times
//        4 → 3 times


namespace FindNumbersOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Input sequence on a single line:");
            List<int> inputSequence;
            string inputLine = Console.ReadLine();
            inputSequence = inputLine
                .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var occurences = CountOccurringNumbers(inputSequence);
            foreach (var occ in occurences)
            {
                Console.WriteLine("{0} -> {1} time(s)", occ.Key, occ.Value);
            }
        }

        static SortedDictionary<int, int> CountOccurringNumbers(List<int> inputSequence)
        {
            var occurences = new SortedDictionary<int, int>();
            foreach (var number in inputSequence)
            {
                if (!occurences.ContainsKey(number))
                {
                    occurences[number] = 0;
                }

                occurences[number]++;
            }

            return occurences;
        }
    }
}
