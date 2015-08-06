namespace ConsoleApplication2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Solution to Increasing Absolute Differences problem.
    /// </summary>
    public class IncreasingAbsoluteDifferencesSolution
    {
        public static void Main(string[] args)
        {
            int numberOfSequences = int.Parse(Console.ReadLine());
            List<int[]> sequences = new List<int[]>();

            for (int i = 0; i < numberOfSequences; i++)
            {
                int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                sequences.Add(sequence);
            }

            bool isIncreasingSequence;
            foreach (int[] seq in sequences)
            {
                isIncreasingSequence = CheckIfIncreasingAbsoluteDifferences(seq);
                Console.WriteLine(isIncreasingSequence);
            }
        }

        /// <summary>
        /// Checks if the absolute differences in a sequence are increasing.
        /// </summary>
        /// <param name="sequence">The input sequence.</param>
        /// <returns>True if the absolute differences in the sequence are increasing, false otherwise.</returns>
        private static bool CheckIfIncreasingAbsoluteDifferences(int[] sequence)
        {
            bool isIncreasing = true;
                List<int> absDifferences = new List<int>();

                absDifferences.Add(Math.Abs(sequence[0] - sequence[1]));

                for (int i = 1; i < sequence.Length - 1; i++)
                {
                    absDifferences.Add(Math.Abs(sequence[i] - sequence[i + 1]));
                    if ((absDifferences[absDifferences.Count - 1] < absDifferences[absDifferences.Count - 2]) || (Math.Abs(absDifferences[absDifferences.Count - 1] - absDifferences[absDifferences.Count - 2]) > 1))
                    {
                        isIncreasing = false;
                        break;
                    }
                }

            return isIncreasing;
        }
    }
}