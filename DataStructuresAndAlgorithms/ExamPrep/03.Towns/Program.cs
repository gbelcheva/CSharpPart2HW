using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Towns
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int[] original = new int[n];
            for (int i = 0; i < n; i++)
            {
                original[i] = int.Parse(Console.ReadLine().Split(' ')[0]);
            }

            Console.WriteLine(LongestIncreasinDecreasingSeq(original));
        }

        //http://tj-devjournal.blogspot.bg/2012/07/longest-increasing-sequence-c.html

        static public int LongestIncreasinDecreasingSeq(int[] sequence)
        {
            int[] maxLengths1 = new int[sequence.Length];  // DP table for max sequence.Length[i]
            int max1 = 0;//int.MinValue;
            int[] maxLengths2 = new int[sequence.Length];  // DP table for max sequence.Length[i]
            int max2 = 0;//int.MinValue;

            maxLengths1[0] = 1;
            maxLengths2[0] = 1;

            for (int i = 0; i < sequence.Length; i++)
            {
                max1 = 0;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i])
                    {
                        max1 = Math.Max(max1, maxLengths1[j]);
                    }
                }

                maxLengths1[i] = max1 + 1;
            }

            for (int i = sequence.Length - 1; i >= 0; i--)
            {
                max2 = 0;

                for (int j = sequence.Length - 1; j > i; j--)
                {
                    if (sequence[j] < sequence[i])
                    {
                        max2 = Math.Max(max2, maxLengths2[j]);
                    }
                }

                maxLengths2[i] = max2 + 1;
            }

            var max = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                var current = maxLengths1[i] + maxLengths2[i] - 1;
                if (current > max)
                {
                    max = current;
                }
            }

            return max;
        }
    }
}
