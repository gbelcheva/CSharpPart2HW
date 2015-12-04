//* The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.

//     Write a program to find the majorant of given array(if exists).
//    Example:
//        {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3


namespace ArrayMajorant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Input sequence on a single line:");
            List<int> numbers;
            string inputLine = Console.ReadLine();
            numbers = inputLine
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int majorant = FindMajorant(numbers);

            Console.Write(majorant == 0 ? " -> Majorant does not exist" : " -> {0}", majorant);
            Console.WriteLine();
        }

        private static int FindMajorant(List<int> numbers)
        {
            var occurences = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!occurences.ContainsKey(numbers[i]))
                {
                    occurences[numbers[i]] = 1;
                }
                else
                {
                    occurences[numbers[i]]++;
                }
            }

            int majorantCondition = numbers.Count / 2 + 1;
            int majorant = occurences.Where(o => o.Value >= majorantCondition).ToArray()[0].Key;

            return majorant;
        }
    }
}
