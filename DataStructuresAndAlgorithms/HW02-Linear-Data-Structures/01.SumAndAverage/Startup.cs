//Write a program that reads from the console a sequence of positive integer numbers.

//    The sequence ends when empty line is entered.
//    Calculate and print the sum and average of the elements of the sequence.
//    Keep the sequence in List<int>.


namespace SumAndAverage
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Input sequence:");
            var inputSeqience = new List<int>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == string.Empty)
                {
                    break;
                }

                int inputNumber = Int32.Parse(inputLine);

                inputSeqience.Add(inputNumber);
            }

            var sum = Sum(inputSeqience);
            Console.WriteLine("Sum = {0}", sum);

            var average = Average(inputSeqience);
            Console.WriteLine("Average = {0}", average);
        }

        static int Sum(ICollection<int> inputSeqience)
        {
            int sum = 0;
            foreach (var number in inputSeqience)
            {
                sum += number;
            }

            return sum;
        }

        static double Average(ICollection<int> inputSeqience)
        {
            double average = Sum(inputSeqience) * 1.0 / inputSeqience.Count;

            return average;
        }
    }
}
