using System;
using System.Numerics;

namespace _01.Redica_Cvetni_Topcheta
{
    class Program
    {
        static void Main(string[] args)
        {
            //var bgcoderLink = "http://bgcoder.com/Contests/Practice/Index/132#3"

            string balls = Console.ReadLine().ToLower();
            int totalBalls = balls.Length;

            int[] repetitions = new int[totalBalls];
            int index = 0;
            for (int i = 0; i <= balls.Length; i++)
            {
                repetitions[index] = balls.Length;
                balls = balls.Replace(balls.Substring(0, 1), "");
                repetitions[index] -= balls.Length;
                index++;
            }

            Array.Sort(repetitions);
            Array.Reverse(repetitions);

            //totalUniquePermutations = totalElements! / (repetition1! * repetition2! * ...)
            BigInteger totalPermutations = FactorialNK(totalBalls, repetitions[0]);
            for (int i = 1; i < repetitions.Length; i++)
            {
                if (repetitions[i] <= 1)
                {
                    break;
                }

                totalPermutations = BigInteger.Divide(totalPermutations, FactorialNK(repetitions[i], 0));
            }

            Console.WriteLine(totalPermutations);
        }

        private static BigInteger FactorialNK(int n, int k)
        {
            BigInteger result = 1;
            while (k < n)
            {
                result = BigInteger.Multiply(result, n--);
            }

            return result;
        }
    }
}
