//Write a program that removes from given sequence all numbers that occur odd number of times.

//    Example:
//        { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}


namespace RemoveOddNumberOccurences
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

            RemoveOddOccurringNumbers(inputSequence);
            Console.WriteLine(string.Join(" ", inputSequence));
        }

        static void RemoveOddOccurringNumbers(List<int> inputSequence)
        {
            for (int i = 0; i < inputSequence.Count; i++)
            {
                var currentNumber = inputSequence[i];
                int count = 0;

                foreach (var number in inputSequence)
                {
                    if (currentNumber == number)
                    {
                        count++;
                    }
                }

                if (count % 2 != 0)
                {
                    inputSequence.RemoveAll(n => n == currentNumber);
                }
            }
        }
    }
}
